using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;
using FuzzySharp;

namespace yazlab1tarifrehberiprojesi.Models
{
    public class MalzemelerRepository : IMalzemelerRepository
    {
        private readonly string _databasebaglanti = "Data Source=DESKTOP-4PT8UQA\\SQLEXPRESS;Initial Catalog=tarifrehberidatabase;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";

        public MalzemelerRepository()
        {

        }
        #region Malzemelerin tümünü listeleme
        public IEnumerable<MalzemelerModeli> GetMalzemeler()
        {
            List<MalzemelerModeli> malzemeler = new List<MalzemelerModeli>();

            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT MalzemeID, MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat FROM MalzemelerTablosu";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool stokDurum = true;
                            if (float.Parse(reader.GetString(2))==0)
                            {
                                stokDurum = false;
                            }
                            malzemeler.Add(new MalzemelerModeli
                            {
                                MalzemeId = reader.GetInt32(0),
                                MalzemeAdi = reader.GetString(1),
                                ToplamMiktar = reader.GetString(2),
                                MalzemeBirim = reader.GetString(3),
                                BirimFiyat = (float)reader.GetDecimal(4),
                                MalzemeDurum=stokDurum

                            });
                        }
                    }
                }
                baglanti.Close();
            }
            return malzemeler;
        }
        #endregion

        #region Malzeme Ekleme
        public void MalzemeEkle(MalzemelerModeli malzemeModeli)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                //string kontrolSorgusu = "SELECT COUNT(*) FROM MalzemelerTablosu WHERE  LOWER(MalzemeAdi) = LOWER(@MalzemeAdi)";
                //using (var komut = new SqlCommand(kontrolSorgusu, baglanti))
                //{
                //    komut.Parameters.AddWithValue("@MalzemeAdi", malzemeModeli.MalzemeAdi);
                //    int duplicate = (int)komut.ExecuteScalar();

                //    if (duplicate > 0)
                //    {
                //        throw new Exception("Bu malzeme adı zaten mevcut.");
                //    }   
                //}
                string kontrolSorgusu = "SELECT MalzemeAdi FROM MalzemelerTablosu";
                List<string> kayitliMalzemeler = new List<string>();

                using (var komut = new SqlCommand(kontrolSorgusu, baglanti))
                {
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kayitliMalzemeler.Add(reader["MalzemeAdi"].ToString());
                        }
                    }
                }
                foreach (var malzeme in kayitliMalzemeler)
                {
                    int malzemeAdiDuplicate = Fuzz.Ratio(malzemeModeli.MalzemeAdi.ToLower(), malzeme.ToLower());
                    if (malzemeAdiDuplicate > 90)
                    {
                        throw new Exception("Bu malzeme adı zaten mevcut veya çok benzer bir malzeme var.");
                    }
                }

                string sqlSorgusu = "INSERT INTO MalzemelerTablosu (MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat) VALUES (@MalzemeAdi, @ToplamMiktar, @MalzemeBirim, @BirimFiyat);SELECT SCOPE_IDENTITY();";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeAdi", malzemeModeli.MalzemeAdi);
                    komut.Parameters.AddWithValue("@ToplamMiktar", malzemeModeli.ToplamMiktar);
                    komut.Parameters.AddWithValue("@MalzemeBirim", malzemeModeli.MalzemeBirim);
                    komut.Parameters.AddWithValue("@BirimFiyat", malzemeModeli.BirimFiyat);
                    komut.ExecuteNonQuery();
                }
                baglanti.Close();
            }
        }
        #endregion

        #region Malzeme Guncelleme
        public void MalzemeGuncelle(MalzemelerModeli malzemeModeli)
        {
             using (var baglanti = new SqlConnection(_databasebaglanti)) 
            { 
                baglanti.Open();
                string sqlSorgusu = "UPDATE MalzemelerTablosu SET MalzemeAdi=@MalzemeAdi, ToplamMiktar=@ToplamMiktar, MalzemeBirim=@MalzemeBirim, BirimFiyat=@BirimFiyat WHERE MalzemeID =@MalzemeID";
                using (var komut=new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeAdi", malzemeModeli.MalzemeAdi);
                    komut.Parameters.AddWithValue("@ToplamMiktar", malzemeModeli.ToplamMiktar);
                    komut.Parameters.AddWithValue("@MalzemeBirim", malzemeModeli.MalzemeBirim);
                    komut.Parameters.AddWithValue("@BirimFiyat", malzemeModeli.BirimFiyat);
                    komut.Parameters.AddWithValue("@MalzemeID", malzemeModeli.MalzemeId);
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion
        
        #region Malzeme Silme
        public void MalzemeSil(int MalzemeId)
        {
            using(var baglanti=new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string malzemekontrolSorgusu = "SELECT COUNT(*) FROM TarifMalzemeIliskisi WHERE MalzemeID = @MalzemeID";
                using (var komut = new SqlCommand(malzemekontrolSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeID", MalzemeId);
                    int ilişkiSayisi = (int)komut.ExecuteScalar();

                    if (ilişkiSayisi > 0) 
                    {
                        MessageBox.Show("Silmek istediğiniz malzeme en az bir tarifte bulunduğu için silinemiyor! Yine de silmek isterseniz malzemenin bulunduğu tarifi güncellemeniz veya silmeniz gerekmektedir.", "Uyarı");
                        return; 
                    }
                }

                string sqlSorgusu = "DELETE FROM MalzemelerTablosu WHERE MalzemeID = @MalzemeID AND MalzemeID NOT IN (SELECT MalzemeID FROM TarifMalzemeIliskisi)";
                using (var komut=new SqlCommand( sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeID", MalzemeId);
                    komut.ExecuteNonQuery();
                }
               
            }
        }
        #endregion

        #region Malzemenin Birimini Getirme 
        public string MalzemeBirimiGetir(int malzemeID)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu= "SELECT MalzemeBirim FROM MalzemelerTablosu WHERE MalzemeID = @MalzemeID";

                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeID", malzemeID);
                    var malzemeBirim = komut.ExecuteScalar()?.ToString();
                    return malzemeBirim;
                }
            }
        }
        #endregion

        #region Malzeme Stok Guncelleme
        public void StokGuncelle(int malzemeID,string toplamMiktar)
        {
            using(var baglanti=new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "UPDATE MalzemelerTablosu SET ToplamMiktar = @ToplamMiktar WHERE MalzemeID = @MalzemeID";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);
                    komut.Parameters.AddWithValue("@MalzemeID", malzemeID); 
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion
        
        #region Secilen Malzemenin idsini bulma
        public int GetMalzemeId(string malzemeAdi)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT MalzemeId FROM MalzemelerTablosu WHERE MalzemeAdi = @MalzemeAdi";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                    var result = komut.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return 0;
        }
        #endregion

        #region Malzeme Detayını Alma
        public MalzemelerModeli GetMalzemeDetay(int malzemeId)
        {
            MalzemelerModeli malzeme = new MalzemelerModeli();
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT  MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat FROM MalzemelerTablosu WHERE MalzemeID = @MalzemeID";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MalzemeID", malzemeId);
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool stokDurum = true;
                            if (float.Parse(reader.GetString(1))==0)
                            {
                                stokDurum = false;
                            }
                            malzeme=new MalzemelerModeli
                            {
                                MalzemeId = malzemeId,
                                MalzemeAdi = reader.GetString(0),
                                ToplamMiktar = reader.GetString(1), 
                                MalzemeBirim = reader.GetString(2),
                                BirimFiyat = (float)reader.GetDecimal(3),
                                MalzemeDurum = stokDurum,
                            };
                        }
                    }
                }
            }
            return malzeme;
        }
        #endregion

        #region Datasetindeki tum farklı birimleri alma
        public List<string> MalzemeBirimleri()
        {
            List<string> birimler = new List<string>();
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "SELECT DISTINCT MalzemeBirim FROM MalzemelerTablosu";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            birimler.Add(reader["MalzemeBirim"].ToString());
                        }
                    }
                }
            }
            return birimler;
        }
        #endregion
    }
    //public string GetBirimMalzemeAdi(string malzemeAdi)
    //{
    //    using (var connection = new SqlConnection(_databasebaglanti))
    //    {
    //        connection.Open();
    //        var komut = new SqlCommand("SELECT MalzemeBirim FROM MalzemelerTablosu WHERE MalzemeAdi = @MalzemeAdi", connection);
    //        komut.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

    //        var birim = komut.ExecuteScalar();
    //        return birim?.ToString();
    //    }
    //}

}
