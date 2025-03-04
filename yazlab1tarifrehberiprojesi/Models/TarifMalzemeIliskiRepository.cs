using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;

namespace yazlab1tarifrehberiprojesi.Models
{
    public class TarifMalzemeIliskiRepository : ITarifMalzemeIliskiRepository
    {
        private readonly string _databasebaglanti = "Data Source=DESKTOP-4PT8UQA\\SQLEXPRESS;Initial Catalog=tarifrehberidatabase;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";

        public TarifMalzemeIliskiRepository()
        {

        }
        #region Tarif malzeme iliskisi ekleme
        public void IliskiEkle(TarifMalzemeIliskisiModeli iliskiModeli)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                //ilişki daha onceden olup olmadıgı kontrolü  yapıldı çakısma hatası için 
                string sqlSorgusu = "SELECT COUNT(*) FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID AND MalzemeID = @MalzemeID";
                using (var kontrolKomut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    kontrolKomut.Parameters.AddWithValue("@TarifID", iliskiModeli.TarifID);
                    kontrolKomut.Parameters.AddWithValue("@MalzemeID", iliskiModeli.MalzemeID);
                    int malzemeIliskisiVar = (int)kontrolKomut.ExecuteScalar();

                    if (malzemeIliskisiVar > 0)
                    {
                        MessageBox.Show("Bu malzeme tarifte zaten tarifte var. Miktarını güncelleme veya silme işlemi yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        sqlSorgusu = "INSERT INTO TarifMalzemeIliskisi (TarifID,MalzemeID,MalzemeMiktar) VALUES (@TarifID,@MalzemeID,@MalzemeMiktar) ";
                        using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@TarifID", iliskiModeli.TarifID);
                            komut.Parameters.AddWithValue("@MalzemeID", iliskiModeli.MalzemeID);
                            komut.Parameters.AddWithValue("@MalzemeMiktar", iliskiModeli.MalzemeMiktar);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Malzeme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                    
            }
        }
        #endregion

        #region Tarif malzeme iliskini Guncelleme
        public void IliskiGuncelle(TarifMalzemeIliskisiModeli iliskiModeli)
        {
            using(var baglanti=new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "UPDATE TarifMalzemeIliskisi SET MalzemeMiktar=@MalzemeMiktar WHERE TarifID=@TarifID AND MalzemeID=@MalzemeID";
                using(var komut = new SqlCommand( sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifID", iliskiModeli.TarifID);
                    komut.Parameters.AddWithValue("@MalzemeID", iliskiModeli.MalzemeID);
                    komut.Parameters.AddWithValue("@MalzemeMiktar", iliskiModeli.MalzemeMiktar.ToString(CultureInfo.InvariantCulture));
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Tarif malzeme iliskisini silme
        public void IliskiSil(int tarifId, int malzemeId)
        {
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                string sqlSorgusu = "DELETE FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID AND MalzemeID = @MalzemeID";

                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifID", tarifId);
                    komut.Parameters.AddWithValue("@MalzemeID", malzemeId);
                    komut.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Tarifin iliskili malzemeleri ve stok durumunu getirme detaylı goruntuleme icin
        public IEnumerable<(string malzeme,int malzemeId, bool stokDurumu)> GetTarifMalzemeler(int tarifId)
        {
            List<(string malzeme, int malzemeId, bool stokDurumu)> malzemelerList = new List<(string, int, bool)>();
            using (var baglanti = new SqlConnection(_databasebaglanti))
            {
                baglanti.Open();
                //string sqlSorgusu = "SELECT tm.MalzemeMiktar,m.MalzemeBirim, m.MalzemeAdi FROM TarifMalzemeIliskisi tm INNER JOIN MalzemelerTablosu m ON tm.MalzemeID = m.MalzemeID WHERE tm.TarifID = @TarifID";
                string sqlSorgusu = @"SELECT TarifMalzemeIliskisi.MalzemeMiktar, MalzemelerTablosu.MalzemeBirim, MalzemelerTablosu.MalzemeAdi, MalzemelerTablosu.ToplamMiktar,TarifMalzemeIliskisi.MalzemeID  FROM TarifMalzemeIliskisi 
                                    INNER JOIN MalzemelerTablosu  ON TarifMalzemeIliskisi.MalzemeID = MalzemelerTablosu.MalzemeID 
                                    WHERE  TarifMalzemeIliskisi.TarifID = @TarifID";
                using (var komut = new SqlCommand(sqlSorgusu, baglanti))
                {
                    komut.Parameters.AddWithValue("@TarifID", tarifId);
                    using (var reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tarifMiktar = reader.GetDouble(0).ToString("0.##");
                            string birim = reader.GetString(1);
                            string malzemeAdi = reader.GetString(2);
                            string stokMiktar = reader.GetString(3);
                            int malzemeId = reader.GetInt32(4);
                            bool malzemeStokDurumu = true;
                            if(float.Parse(stokMiktar) < float.Parse(tarifMiktar))
                            {
                                malzemeStokDurumu=false;
                            }
                            //Console.WriteLine($"{tarifMiktar} {birim} {malzemeAdi} "+malzemeId + malzemeStokDurumu);
                            malzemelerList.Add(($"{tarifMiktar} {birim} {malzemeAdi}",malzemeId, malzemeStokDurumu));
                        }
                    }
                }
                return malzemelerList;
            }
        }
        #endregion
    }
}
