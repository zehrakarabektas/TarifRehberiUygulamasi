using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;
using yazlab1tarifrehberiprojesi.Models;

namespace yazlab1tarifrehberiprojesi.Views
{
    public partial class MalzemelerEkleSil : UserControl
    {
        private readonly MalzemelerRepository malzemelerRepo;
        private int malzemeId;

        public int MalzemeId { get => malzemeId; set => malzemeId=value; }

        public event EventHandler MalzemeEklemeButonuBasildi;
        public MalzemelerEkleSil()
        {
            InitializeComponent();
            malzemelerRepo = new MalzemelerRepository();
        }

        private void malzemeekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(malzemeAdi_txt.Text) ||
                    string.IsNullOrWhiteSpace(toplammiktar_txt.Text) ||
                    birim_cmbox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(birimFiyat_txt.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }
                var malzemeModeli = new MalzemelerModeli
                {
                    MalzemeAdi = malzemeAdi_txt.Text,
                    ToplamMiktar= toplammiktar_txt.Text,
                    MalzemeBirim=birim_cmbox.SelectedItem.ToString(),
                    BirimFiyat=float.Parse(birimFiyat_txt.Text)
                };
                malzemelerRepo.MalzemeEkle(malzemeModeli);
                MessageBox.Show("Malzeme başarıyla eklendi!");
                MalzemeEklemeButonuBasildi?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme eklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
