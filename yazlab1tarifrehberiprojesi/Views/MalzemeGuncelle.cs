using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;
using yazlab1tarifrehberiprojesi.Models;
using yazlab1tarifrehberiprojesi.Views;

namespace yazlab1tarifrehberiprojesi
{
    public partial class MalzemeGuncelle : UserControl
    {
        private int malzemeId;
        private string eskiMalzemeAdi, eskiToplamMiktar, eskiMalzemeBirim;
        private float eskiBirimFiyat;
        private readonly MalzemelerRepository malzemelerRepo;

        public event EventHandler MalzemeGuncellemeButonunaBasildi;

        public void SetMalzemeId(int malzemeId)
        {
            this.malzemeId= malzemeId;
        }

        public MalzemeGuncelle()
        {
            InitializeComponent();
            malzemelerRepo = new MalzemelerRepository();
        }

        public void MalzemeGuncelle_Load(object sender, EventArgs e)
        {
            MalzemelerModeli malzeme = new MalzemelerModeli();
            malzeme=malzemelerRepo.GetMalzemeDetay(malzemeId);
            var birimler = malzemelerRepo.MalzemeBirimleri().ToList();
            //Console.WriteLine(malzemeId);
            //Console.WriteLine("Malzeme Adı: " + malzeme.MalzemeAdi);
            //Console.WriteLine("Malzeme stok: " + malzeme.ToplamMiktar);
            //Console.WriteLine("Malzeme birim: " + malzeme.MalzemeBirim);
            //Console.WriteLine("Malzeme birim fiyat: " + malzeme.BirimFiyat);
           

            if (malzeme != null)
            {
                //Girilmeyen bir bilgi için eski bilgilerin tutulması saglandı
                eskiMalzemeAdi = malzeme.MalzemeAdi;
                eskiMalzemeBirim=malzeme.MalzemeBirim;
                eskiToplamMiktar=malzeme.ToplamMiktar;
                eskiBirimFiyat=malzeme.BirimFiyat;

                malzemeAdi_txt.Text = string.Empty;
                toplammiktar_txt.Text = string.Empty;
                birim_cmbox.Text = string.Empty;
                birimFiyat_txt.Text = string.Empty;

                malzemeAdi_txt.Size = new Size(200, 50);
                malzemeAdi_txt.Text = malzeme.MalzemeAdi;
                toplammiktar_txt.Text = malzeme.ToplamMiktar;
                birimFiyat_txt.Text = malzeme.BirimFiyat.ToString("F2");

                birim_cmbox.DataSource = birimler;
                birim_cmbox.DropDownStyle = ComboBoxStyle.DropDown;
                if (birimler.Contains(malzeme.MalzemeBirim))
                {
                    birim_cmbox.SelectedItem = malzeme.MalzemeBirim; 
                }


            }
            else
            {
                MessageBox.Show("Tarif bulunamadı.");
            }
        }
        private void malzemeekle_Click(object sender, EventArgs e)
        {
            string malzemeAdi = malzemeAdi_txt.Text;
            string toplamMiktar = toplammiktar_txt.Text;
            
            malzemeAdi = string.IsNullOrWhiteSpace(malzemeAdi) ? eskiMalzemeAdi : malzemeAdi;
            toplamMiktar = string.IsNullOrWhiteSpace(toplamMiktar) ? eskiToplamMiktar : toplamMiktar;
            string malzemeBirim = string.IsNullOrWhiteSpace(birim_cmbox.Text) ? eskiMalzemeBirim : birim_cmbox.Text;

            float birimFiyat;
            if (!float.TryParse(birimFiyat_txt.Text, out birimFiyat))
            {
                birimFiyat = eskiBirimFiyat; 
            }

            MalzemelerModeli malzemeModeli = new MalzemelerModeli
            {
                MalzemeId = malzemeId,
                MalzemeAdi = malzemeAdi,
                ToplamMiktar = toplamMiktar,
                MalzemeBirim = malzemeBirim,
                BirimFiyat = birimFiyat
            };
            try
            {
                malzemelerRepo.MalzemeGuncelle(malzemeModeli);
                MalzemeGuncelle_Load(this, EventArgs.Empty);
                MalzemeGuncellemeButonunaBasildi?.Invoke(sender, e);
                MessageBox.Show("Malzeme başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme güncellenirken bir hata oluştu: " + ex.Message);
            }

        }

    }

}
