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
    public partial class TarifEkle : UserControl
    {
        private string tarifImagePath = "";
        private readonly TariflerRepository tariflerRepository;
        private readonly MalzemelerRepository malzemelerRepo;
        private readonly TarifMalzemeIliskiRepository tarifMalzemeRepo;
        public event EventHandler TarifEklemeButonunaBasildi;
        private int malzemeId,tarifId;
        public TarifEkle()
        {
            InitializeComponent();
            tariflerRepository = new TariflerRepository();
            malzemelerRepo = new MalzemelerRepository();
            tarifMalzemeRepo=new TarifMalzemeIliskiRepository();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog  dosya=new OpenFileDialog();
                dosya.Filter="Image Files(*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    tarifImagePath=dosya.FileName;
                    tarifresim_pbox.ImageLocation=tarifImagePath;
                }
                else
                {
                    TarifImageBox.ImageLocation=null;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
            
        }
        private void tarifekle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string kategoriAdi = kategori_cmbox.Text;

                if (string.IsNullOrWhiteSpace(kategoriAdi) || kategoriAdi == "Yeni Kategori")
                {
                    MessageBox.Show("Lütfen geçerli bir kategori seçiniz veya yazınız.");
                    return;
                }

                var tarifModeli = new TariflerModeli
                {
                    TarifAdi = taridadi_txt.Text,
                    KategoriAdi = kategoriAdi,
                    HazirlamaSüresi = int.Parse(sure_txt.Text),
                    Talimatlar = talimat_txtbox.Text,
                    TarifResmi = tarifImagePath
                };
                tarifId = tariflerRepository.TarifEkle(tarifModeli);
                MessageBox.Show("Tarif başarıyla eklendi!");
                TarifEklemeButonunaBasildi?.Invoke(sender,e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarif eklenirken bir hata oluştu: " + ex.Message);
            }
        }


        private void malzeme_btn_Click(object sender, EventArgs e)
        {
            string secilenMalzemeAdi = malzemead_cmbox.SelectedItem?.ToString();
            string secilenMiktar = miktar_txt.Text;
            string secilenBirim = birim_cmbox.Text;
            EklenenMalzemeler.Items.Add(secilenMalzemeAdi+" "+secilenMiktar+" "+secilenBirim);
            if (!string.IsNullOrEmpty(secilenMalzemeAdi) && secilenMalzemeAdi != "Malzeme Seçiniz")
            {
                malzemeId = malzemelerRepo.GetMalzemeId(secilenMalzemeAdi);

                if (malzemeId != -1)
                {
                    //MessageBox.Show($"Seçilen Malzeme ID: {malzemeId}");
                    var tarifMalzemeModeli = new TarifMalzemeIliskisiModeli
                    {
                        TarifID=tarifId,
                        MalzemeID=malzemeId,
                        MalzemeMiktar=float.Parse(secilenMiktar)
                    };
                    tarifMalzemeRepo.IliskiEkle(tarifMalzemeModeli);
                }
                else
                {
                    MessageBox.Show("Malzeme bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir malzeme seçiniz.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var malzemeler = malzemelerRepo.GetMalzemeler(); 
                var malzemeAdlari = malzemeler.Select(m => m.MalzemeAdi).ToList();
                malzemeAdlari.Insert(0, "Malzeme Seçiniz");
                malzemead_cmbox.DataSource = malzemeAdlari;
                malzemead_cmbox.DropDownStyle = ComboBoxStyle.DropDownList;
                birim_cmbox.Items.Clear();
                birim_cmbox.Items.Add("Birim");
                birim_cmbox.SelectedIndex = 0;
                var kategoriler = tariflerRepository.TarifKategorileri().ToList();

                kategoriler.Insert(0, "Yeni Kategori");

                kategori_cmbox.DataSource = kategoriler;
                
                kategori_cmbox.DropDownStyle = ComboBoxStyle.DropDown;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme adları yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
       
        private void malzemead_cmbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secilenMalzeme = malzemead_cmbox.SelectedItem?.ToString();

            MalzemelerRepository malzemelerRepo = new MalzemelerRepository();

            if (secilenMalzeme != null && secilenMalzeme != "Malzeme Seçiniz")
            {
                malzemeId = malzemelerRepo.GetMalzemeId(secilenMalzeme);
                var birim = malzemelerRepo.MalzemeBirimiGetir(malzemeId); 

                if (birim != null)
                {
                    birim_cmbox.Text = birim; 
                }
            }
            else
            {
                birim_cmbox.Text = "Birim"; 
            }
        }

        private void kategori_cmbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (kategori_cmbox.SelectedItem != null && kategori_cmbox.SelectedItem.ToString() == "Yeni Kategori")
            {
                kategori_cmbox.Text = ""; 
                kategori_cmbox.DropDownStyle = ComboBoxStyle.DropDown; 
            }
            else
            {
                kategori_cmbox.DropDownStyle = ComboBoxStyle.DropDownList; 
            }
        }
        

    }
}
