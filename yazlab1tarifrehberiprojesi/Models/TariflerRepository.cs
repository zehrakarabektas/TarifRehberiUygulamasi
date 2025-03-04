using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;
using yazlab1tarifrehberiprojesi.Views;
using FuzzySharp;

namespace yazlab1tarifrehberiprojesi.Models
{
    internal class TariflerRepository : ITariflerRepository
    {
        private readonly string _databasebaglanti = "Data Source=DESKTOP-4PT8UQA\\SQLEXPRESS;Initial Catalog=tarifrehberidatabase;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";

        public TariflerRepository()
        {

        }
        #region Tüm Tarif Listeleme
        public IEnumerable<TariflerModeli> GetAll()
        {
            List<TariflerModeli> tarifler = new List<TariflerModeli>();

            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT TarifID, TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi FROM TariflerTablosu";
                
            
                using (var command = new SqlCommand(sqlSorgusu, baglanti))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var (toplamStokMaliyeti, toplamTarifMaliyeti)= TarifMaliyetiHesapla(reader.GetInt32(0));
                            bool tarifStok = false;
                            if (toplamStokMaliyeti==0)
                            {
                                tarifStok=true;
                            }
                            tarifler.Add(new TariflerModeli
                            {
                                TarifID = reader.GetInt32(0),
                                TarifAdi = reader.GetString(1),
                                KategoriAdi = reader.GetString(2),
                                HazirlamaSüresi =reader.GetInt32(3),
                                Talimatlar = reader.GetString(4),
                                TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5),
                                TarifMaliyeti=toplamTarifMaliyeti,
                                StokMaliyeti=toplamStokMaliyeti,
                                TarifStokDurumu=tarifStok,
                                EslesmeYuzdesi=0
                            });
                        }
                    }
                }
            }
            return tarifler;
        }
        #endregion

        #region Tarifleri Listeleme (hem tüm tarifleri alarak hem de arama, filtreleme ve malzemeye göre sıralama seçeneklerini kullanarak listemele fonksiyonu)
        public IEnumerable<TariflerModeli> GetTariflerListesi(string kategori, string malzemeSayisi, string maliyetAraligi, List<int> secilenMalzemeIdleri,int sirala, string arama)
        {
            List<TariflerModeli> tarifler = new List<TariflerModeli>();

            int minMalzemeSayisi = 0, maxMalzemeSayisi = 0,malzemeSay=0;
            float minMaliyetAraligi = 0, maxMaliyetAraligi = 0;
            bool maliyetAraligiFiltrelenmis = false,malzemeSayisiFiltrelenmis=false;
            int toplamSecilenMalzemeSayisi = 0,secilenMalzemeTarifEslesmeSayisi=0;
            float eslesmeYuzdesi = 0;

            //Console.WriteLine("Form1 de kategori"+kategori+"malzeme"+malzemeSayisi+"maliyet"+maliyetAraligi);

            if (!string.IsNullOrEmpty(maliyetAraligi) && maliyetAraligi.Contains("-"))
            {
                var maliyetAraligiDegerleri = maliyetAraligi.Split('-');
                if (maliyetAraligiDegerleri.Length == 2 &&
                    float.TryParse(maliyetAraligiDegerleri[0], out minMaliyetAraligi) &&
                    float.TryParse(maliyetAraligiDegerleri[1], out maxMaliyetAraligi))
                {
                    maliyetAraligiFiltrelenmis = true;
                }
            }
            if (!string.IsNullOrEmpty(malzemeSayisi))
            {
                if (malzemeSayisi.Contains("-"))
                {
                    var malzemeSayisiAraligi = malzemeSayisi.Split('-');

                    if (malzemeSayisiAraligi.Length == 2 &&
                        int.TryParse(malzemeSayisiAraligi[0].Trim(), out minMalzemeSayisi) &&
                        int.TryParse(malzemeSayisiAraligi[1].Trim(), out maxMalzemeSayisi))
                    {
                        malzemeSayisiFiltrelenmis=true;
                    }
                }
                else
                {
                    if (int.TryParse(malzemeSayisi, out malzemeSay))
                    {
                        malzemeSayisiFiltrelenmis=true;
                    }
                }
            }
            //Console.WriteLine("tariflerrepo minmalzeme+maxmalzeme"+minMalzemeSayisi+"  "+maxMalzemeSayisi+"maliyet"+minMaliyetAraligi+"   "+maxMaliyetAraligi);

            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();

                string sqlSorgusu = @"SELECT TariflerTablosu.TarifID, TariflerTablosu.TarifAdi, TariflerTablosu.KategoriAdi, 
                                     TariflerTablosu.HazirlamaSüresi, TariflerTablosu.Talimatlar, TariflerTablosu.TarifResmi FROM TariflerTablosu  WHERE 1=1";
                if (!string.IsNullOrEmpty(arama))
                {
                    sqlSorgusu += @" AND (EXISTS (SELECT 1 FROM TarifMalzemeIliskisi 
                                     JOIN MalzemelerTablosu ON TarifMalzemeIliskisi.MalzemeID = MalzemelerTablosu.MalzemeID
                                     WHERE TarifMalzemeIliskisi.TarifID = TariflerTablosu.TarifID 
                                     AND MalzemelerTablosu.MalzemeAdi LIKE '%' + @Arama + '%') OR TariflerTablosu.TarifAdi LIKE '%' + @Arama + '%')";
                }
               
                if (!string.IsNullOrEmpty(kategori))
                {
                    sqlSorgusu += " AND LOWER(TariflerTablosu.KategoriAdi) LIKE '%' + LOWER(@KategoriAdi) + '%'";
                }
                if(!string.IsNullOrEmpty(malzemeSayisi))
                {
                    if (minMalzemeSayisi != 0 || maxMalzemeSayisi != 0)
                    {
                        sqlSorgusu += @" AND (SELECT COUNT(*) 
                                  FROM TarifMalzemeIliskisi 
                                  WHERE TarifMalzemeIliskisi.TarifID = TariflerTablosu.TarifID) 
                                  BETWEEN @MinMalzemeSayisi AND @MaxMalzemeSayisi";
                    }
                    else
                    {
                        sqlSorgusu += @" AND (SELECT COUNT(*) 
                                  FROM TarifMalzemeIliskisi 
                                  WHERE TarifMalzemeIliskisi.TarifID = TariflerTablosu.TarifID) = @MalzemeSayisi";
                    }

                }
                //if (sirala != 0)
                //{
                //    switch (sirala)
                //    {
                //        case 1:
                //            sqlSorgusu += " ORDER BY HazirlamaSüresi DESC";
                //            break;
                //        case 2:
                //            sqlSorgusu += " ORDER BY HazirlamaSüresi ASC";
                //            break;
                //        case 3:
                //            sqlSorgusu += " ORDER BY TarifMaliyeti ASC";
                //            break;
                //        case 4:
                //            sqlSorgusu += " ORDER BY TarifMaliyeti DESC";
                //            break;
                //        case 5:
                //            sqlSorgusu += " ORDER BY StokMaliyeti ASC";
                //            break;
                //        case 6:
                //            sqlSorgusu += " ORDER BY StokMaliyeti DESC";
                //            break;
                //        default:
                //            break;
                //    }
                //}
                using (var command = new SqlCommand(sqlSorgusu, baglanti))
                {
                    if (!string.IsNullOrEmpty(kategori))
                    {
                        command.Parameters.AddWithValue("@KategoriAdi", kategori);
                    }
                    if (!string.IsNullOrEmpty(malzemeSayisi))
                    {
                        if(minMalzemeSayisi!=0||maxMalzemeSayisi!=0)
                        {
                            command.Parameters.AddWithValue("@MinMalzemeSayisi", minMalzemeSayisi);
                            command.Parameters.AddWithValue("@MaxMalzemeSayisi", maxMalzemeSayisi);
                        }
                        else if (int.TryParse(malzemeSayisi, out int malzemeSayisiDegeri))
                        {
                            command.Parameters.AddWithValue("@MalzemeSayisi", malzemeSay);
                        }
                    }
                    if (!string.IsNullOrEmpty(arama))
                    {
                        command.Parameters.AddWithValue("@Arama", arama);
                    }
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var (toplamStokMaliyeti, toplamTarifMaliyeti)= TarifMaliyetiHesapla(reader.GetInt32(0));
                            bool tarifStok = false;
                            if (toplamStokMaliyeti==0)
                            {
                                tarifStok=true;
                            }
                            
                            if (maliyetAraligiFiltrelenmis)
                            {
                                if (toplamTarifMaliyeti < minMaliyetAraligi || toplamTarifMaliyeti > maxMaliyetAraligi)
                                {
                                    continue; 
                                }
                            }
                            if (secilenMalzemeIdleri!=null)
                            {
                                toplamSecilenMalzemeSayisi = secilenMalzemeIdleri.Count;
                                //Console.WriteLine(toplamSecilenMalzemeSayisi);
                                secilenMalzemeTarifEslesmeSayisi= secilenMalzemeTarifMalzemeEslesmesiHesapla(reader.GetInt32(0),secilenMalzemeIdleri);
                                //Console.WriteLine(secilenMalzemeTarifEslesmeSayisi);
                                eslesmeYuzdesi = toplamSecilenMalzemeSayisi > 0 ? ((float)secilenMalzemeTarifEslesmeSayisi/ toplamSecilenMalzemeSayisi) * 100 : 0;
                                eslesmeYuzdesi=(float)Math.Round(eslesmeYuzdesi, 2);
                            }
                            tarifler.Add(new TariflerModeli
                            {
                                TarifID = reader.GetInt32(0),
                                TarifAdi = reader.GetString(1),
                                KategoriAdi = reader.GetString(2),
                                HazirlamaSüresi = reader.GetInt32(3),
                                Talimatlar = reader.GetString(4),
                                TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5),
                                TarifMaliyeti=toplamTarifMaliyeti,
                                StokMaliyeti=toplamStokMaliyeti,
                                TarifStokDurumu=tarifStok,
                                EslesmeYuzdesi=eslesmeYuzdesi
                            });
                        }
                    }
                }
                if (arama!=null)
                {
                    tarifler=tarifler.GroupBy(t => t.TarifID).Select(g => g.First()).ToList();
                }
                if (sirala != 0)
                {
                    switch (sirala)
                    {
                        case 1:
                            tarifler = tarifler.OrderByDescending(tarif => tarif.HazirlamaSüresi).ToList();
                            break;
                        case 2:
                            tarifler = tarifler.OrderBy(tarif => tarif.HazirlamaSüresi).ToList();
                            break;
                        case 3:
                            tarifler = tarifler.OrderBy(tarif => tarif.TarifMaliyeti).ToList();
                            break;
                        case 4:
                            tarifler = tarifler.OrderByDescending(tarif => tarif.TarifMaliyeti).ToList();
                            break;
                        case 5:
                            tarifler = tarifler.OrderBy(tarif => tarif.StokMaliyeti).ToList();
                            break;
                        case 6:
                            tarifler = tarifler.OrderByDescending(tarif => tarif.StokMaliyeti).ToList();
                            break;
                        default:
                            break;
                    }
                }
                if (secilenMalzemeIdleri!=null)
                {
                    tarifler = tarifler.OrderByDescending(tarif => tarif.EslesmeYuzdesi).ToList();
                }
                
            }
            return tarifler;
        }
        #endregion

        #region Secilen Tarifin Detayını Alma Fonksiyonu
        public TariflerModeli GetTarifDetay(int tarifId)
        {
            TariflerModeli tarif = new TariflerModeli();
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT TarifId, TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi FROM TariflerTablosu WHERE TarifId = @TarifId";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifId",tarifId);
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var (stokMaliyeti,toplamTarifMaliyeti)= TarifMaliyetiHesapla(reader.GetInt32(0));
                            tarif=new TariflerModeli
                            {
                                TarifID = reader.GetInt32(0),
                                TarifAdi = reader.GetString(1),
                                KategoriAdi = reader.GetString(2),
                                HazirlamaSüresi =reader.GetInt32(3),
                                Talimatlar = reader.GetString(4),
                                TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5),
                                TarifMaliyeti=toplamTarifMaliyeti,
                                StokMaliyeti=stokMaliyeti
                            };
                        }
                    }
                }
            }
            return tarif;
        }
        #endregion

        #region Tarif Ekleme Fonksiyonu
        public int TarifEkle(TariflerModeli tarifModeli)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string kontrolSorgusu = "SELECT COUNT(*) FROM TariflerTablosu WHERE LOWER(TarifAdi) = LOWER(@TarifAdi)";
                using (var komut = new SqlCommand(kontrolSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifAdi", tarifModeli.TarifAdi);
                    int duplicate = (int)komut.ExecuteScalar();

                    if (duplicate > 0)
                    {
                        throw new Exception("Bu tarif adı zaten mevcut.");
                    }
                }
                kontrolSorgusu = "SELECT TarifAdi FROM TariflerTablosu";
                List<string> kayitliTarifler= new List<string>();

                using (var komut = new SqlCommand(kontrolSorgusu, baglanti))
                {
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kayitliTarifler.Add(reader["TarifAdi"].ToString());
                        }
                    }
                }
                foreach (var tarif in kayitliTarifler)
                {
                    int tarifAdiDuplicate = Fuzz.Ratio(tarifModeli.TarifAdi.ToLower(), tarif.ToLower());
                    if (tarifAdiDuplicate > 90) 
                    {
                        throw new Exception("Bu tarif adı zaten mevcut veya çok benzer bir tarif var.");
                    }
                }

                string sqlSorgusu = "INSERT INTO TariflerTablosu (TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi) VALUES (@TarifAdi, @KategoriAdi, @HazirlamaSüresi, @Talimatlar, @TarifResmi);SELECT SCOPE_IDENTITY();";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifAdi", tarifModeli.TarifAdi);
                    komut.Parameters.AddWithValue("@KategoriAdi", tarifModeli.KategoriAdi);
                    komut.Parameters.AddWithValue("@HazirlamaSüresi", tarifModeli.HazirlamaSüresi);
                    komut.Parameters.AddWithValue("@Talimatlar", tarifModeli.Talimatlar);
                    komut.Parameters.AddWithValue("@TarifResmi", (object)tarifModeli.TarifResmi ?? DBNull.Value);
                    //komut.ExecuteNonQuery();
                    object result = komut.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int yeniTarifId))
                    {
                        return yeniTarifId;
                    }
                    else
                    {
                        throw new Exception("Tarif eklenirken yeni TarifId'ye ulaşılamadı. Lütfen veritabanı bağlantınızı kontrol edin.");
                    }

                }
            }
        }
        #endregion

        #region Tarif Guncelleme Fonksiyonu
        public void TarifGuncelle(TariflerModeli tarifModeli, int tarifId)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "UPDATE TariflerTablosu SET TarifAdi = @TarifAdi, KategoriAdi = @KategoriAdi, HazirlamaSüresi = @HazirlamaSüresi, Talimatlar = @Talimatlar, TarifResmi = @TarifResmi WHERE TarifID =@TarifID";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifAdi", tarifModeli.TarifAdi);
                    komut.Parameters.AddWithValue("@KategoriAdi", tarifModeli.KategoriAdi);
                    komut.Parameters.AddWithValue("@HazirlamaSüresi", tarifModeli.HazirlamaSüresi);
                    komut.Parameters.AddWithValue("@Talimatlar", tarifModeli.Talimatlar);
                    komut.Parameters.AddWithValue("@TarifResmi", tarifModeli.TarifResmi);
                    komut.Parameters.AddWithValue("@TarifID", tarifId);
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion
        
        #region Tarif Silme Fonksiyonu
        public void TarifSil(int tarifId)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "DELETE FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID";
                using (var silCommand = new SqlCommand(sqlSorgusu, baglanti))
                {
                    silCommand.Parameters.AddWithValue("@TarifID", tarifId);
                    silCommand.ExecuteNonQuery();
                }

                sqlSorgusu = "DELETE FROM TariflerTablosu WHERE TarifID = @TarifID";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifID", tarifId);
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion
       
        #region Datasetteki Tarif Kategori Adlarını listeleme Fonksiyonu
        public List<string> TarifKategorileri()
        {
            List<string> kategoriler = new List<string>();
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT DISTINCT KategoriAdi FROM TariflerTablosu";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kategoriler.Add(reader["KategoriAdi"].ToString());
                        }
                    }
                }
            }
            return kategoriler;
        }
        #endregion

        #region Tarifin datasetinden gelen bilgilerine gore stok ve toplam maliyeti hesaplatma fonksiyonu
        private (float stokMaliyeti, float toplamTarifMaliyeti) TarifMaliyetiHesapla(int tarifId)
        {
            float stokMaliyeti = 0;
            float toplamTarifMaliyeti = 0;
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = @"SELECT  TarifMalzemeIliskisi.MalzemeMiktar, MalzemelerTablosu.BirimFiyat, MalzemelerTablosu.ToplamMiktar
                           FROM TarifMalzemeIliskisi 
                           JOIN MalzemelerTablosu ON TarifMalzemeIliskisi.MalzemeID=MalzemelerTablosu.MalzemeID
                           WHERE TarifMalzemeIliskisi.TarifID=@TarifID ";
                using (var command = new SqlCommand(sqlSorgusu, baglanti))
                {
                    command.Parameters.AddWithValue("@TarifID", tarifId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                double tarifMalzemeMiktari = reader.GetDouble(0);
                                decimal malzemeBirimFiyati = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                string toplamMiktarStr = reader.IsDBNull(2) ? null : reader.GetString(2);
                                toplamTarifMaliyeti+=(float)((decimal)tarifMalzemeMiktari*malzemeBirimFiyati);

                                //Console.WriteLine($"Tarif Miktar: {tarifMalzemeMiktari}, Birim Fiyat: {malzemeBirimFiyati}, Toplam Miktar: {toplamMiktarStr}");

                                float malzemeStokMiktari = float.Parse(toplamMiktarStr);
                               // Console.WriteLine($"Stok Miktar: {malzemeStokMiktari}");
                                if (malzemeStokMiktari < (float)tarifMalzemeMiktari)
                                {
                                    stokMaliyeti +=(float)((decimal)(tarifMalzemeMiktari - malzemeStokMiktari)* malzemeBirimFiyati);
                                   // Console.WriteLine($"Güncel Maliyet: {stokMaliyeti}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Veritabanında herhangi bir veri bulunamadı.");
                        }
                    }
                }
            }
            stokMaliyeti = (float)Math.Round(stokMaliyeti, 2);
            toplamTarifMaliyeti = (float)Math.Round(toplamTarifMaliyeti, 2);
            return (stokMaliyeti,toplamTarifMaliyeti); 
        }
        #endregion

        #region Secilen malzemeler ile kayıtlı tariflerin eslesme sayısını hesaplatma fonksiyonu
        private int secilenMalzemeTarifMalzemeEslesmesiHesapla(int tarifID, List<int> secilenMalzemeIdleri)
        {
            int eslesmeSayisi= 0;
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = @"SELECT COUNT(*) FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID AND MalzemeID IN (" + string.Join(",", secilenMalzemeIdleri) + ")";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifID", tarifID);
                    eslesmeSayisi = (int)komut.ExecuteScalar();
                }
            }
            return eslesmeSayisi;
        }
        #endregion

        
    }
}
#region denenmis hatalı kod parcası
//public IEnumerable<TariflerModeli> TarifMalzemeAramaYap(string arama)
//{
//    List<TariflerModeli> tarifler = new List<TariflerModeli>();
//    arama = arama.Trim();

//    using (var baglanti = new SqlConnection(_databasebaglanti))
//    {
//        baglanti.Open();
//        string sqlSorgusu = @"SELECT TariflerTablosu.TarifID, TariflerTablosu.TarifAdi, TariflerTablosu.KategoriAdi, TariflerTablosu.HazirlamaSüresi, TariflerTablosu.Talimatlar, 
//                              TariflerTablosu.TarifResmi FROM TariflerTablosu 
//                              JOIN TarifMalzemeIliskisi ON TariflerTablosu.TarifID = TarifMalzemeIliskisi.TarifID
//                              JOIN MalzemelerTablosu ON TarifMalzemeIliskisi.MalzemeID = MalzemelerTablosu.MalzemeID
//                              WHERE TariflerTablosu.TarifAdi LIKE '%' + @arama + '%'   OR MalzemelerTablosu.MalzemeAdi LIKE '%' + @arama + '%'";


//        using (var command = new SqlCommand(sqlSorgusu, baglanti))
//        {
//            command.Parameters.AddWithValue("@arama", arama);
//            using (var reader = command.ExecuteReader())
//            {   
//                while (reader.Read())
//                {
//                    var (toplamStokMaliyeti, toplamTarifMaliyeti)= TarifMaliyetiHesapla(reader.GetInt32(0));
//                    bool tarifStok = false;
//                    if (toplamStokMaliyeti==0)
//                    {
//                        tarifStok=true;
//                    }
//                    Console.WriteLine(tarifStok);
//                    tarifler.Add(new TariflerModeli
//                    {
//                        TarifID = reader.GetInt32(0),
//                        TarifAdi = reader.GetString(1),
//                        KategoriAdi = reader.GetString(2),
//                        HazirlamaSüresi =reader.GetInt32(3),
//                        Talimatlar = reader.GetString(4),
//                        TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5),
//                        TarifMaliyeti=toplamTarifMaliyeti,
//                        StokMaliyeti=toplamStokMaliyeti,
//                        TarifStokDurumu=tarifStok,
//                        EslesmeYuzdesi=0
//                    });
//                }
//            }
//        }
//    }
//    tarifler=tarifler.GroupBy(t => t.TarifID).Select(g => g.First()).ToList();
//    return tarifler;
//}
//public IEnumerable<TariflerModeli> GetByCategory(string kategori)
//{
//    List<TariflerModeli> tarifler = new List<TariflerModeli>();
//    using (var baglanti = new SqlConnection(_databasebaglanti))
//    {
//        baglanti.Open();
//        string sqlSorgusu = "SELECT TarifID, TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi FROM TariflerTablosu WHERE KategoriAdi=@KategoriAdi";
//        using (var command = new SqlCommand(sqlSorgusu, baglanti))
//        {
//            command.Parameters.AddWithValue("@KategoriAdi", kategori);
//            using (var reader = command.ExecuteReader())
//            {
//                while (reader.Read())
//                {
//                    var (toplamStokMaliyeti, toplamTarifMaliyeti)= TarifMaliyetiHesapla(reader.GetInt32(0));
//                    bool tarifStok = false;
//                    if (toplamStokMaliyeti==0)
//                    {
//                        tarifStok=true;
//                    }
//                    tarifler.Add(new TariflerModeli
//                    {
//                        TarifID = reader.GetInt32(0),
//                        TarifAdi = reader.GetString(1),
//                        KategoriAdi = reader.GetString(2),
//                        HazirlamaSüresi = reader.GetInt32(3),
//                        Talimatlar = reader.GetString(4),
//                        TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5),
//                        TarifMaliyeti=toplamTarifMaliyeti,
//                        StokMaliyeti=toplamStokMaliyeti,
//                        TarifStokDurumu=tarifStok,
//                        EslesmeYuzdesi=0

//                    });

//                }
//            }
//        }
//    }
//    return tarifler;
//}
//public IEnumerable<TariflerModeli> GetByName(string tarifadi)
//{
//    List<TariflerModeli> tarifler = new List<TariflerModeli>();
//    using (var baglanti = new SqlConnection(_databasebaglanti))
//    {
//        baglanti.Open();
//        string sqlSorgusu = "SELECT TarifID, TarifAdi, KategoriAdi, HazirlamaSüresi, Talimatlar, TarifResmi FROM TariflerTablosu WHERE TarifAdi LIKE @TarifAdi";
//        using (var command = new SqlCommand(sqlSorgusu, baglanti))
//        {
//            command.Parameters.AddWithValue("@TarifAdi", "%" + tarifadi + "%");
//            using (var reader = command.ExecuteReader())
//            {
//                while (reader.Read())
//                {
//                    tarifler.Add(new TariflerModeli
//                    {
//                        TarifID = reader.GetInt32(0),
//                        TarifAdi = reader.GetString(1),
//                        KategoriAdi = reader.GetString(2),
//                        HazirlamaSüresi = reader.GetInt32(3),
//                        Talimatlar = reader.GetString(4),
//                        TarifResmi = reader.IsDBNull(5) ? null : reader.GetString(5)
//                    });
//                }
//            }
//        }
//    }
//    return tarifler;
//}
#endregion