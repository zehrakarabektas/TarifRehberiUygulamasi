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
    public partial class Tarifler : UserControl
    {
        private string kategori=null ;
        private int filtrele = 0;
        private bool malzemeSecildi = false;
        private int sirala = 0;
        private string malzemeSayisi=null;
        private string tarifMaliyetiAraligi=null;
        private List<int> secilenMalzemeIdleri=null;

        private string arama = null;
        string guncelleIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\guncelle.png";
        string silIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\sil.png";
        string goruntuleIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\search.png";
        public event EventHandler<int> TarifGoruntuleButonunaBasildi;
        public event EventHandler<int> TarifGuncelleButonunaBasildi;
        public string Kategori { get => kategori; set => kategori=value; }
        public string MalzemeSayisi { get => malzemeSayisi; set => malzemeSayisi=value; }
        public string TarifMaliyetiAraligi { get => tarifMaliyetiAraligi; set => tarifMaliyetiAraligi=value; }
        public int Sirala { get => sirala; set => sirala=value; }
        public int Filtrele { get => filtrele; set => filtrele=value; }
        public string Arama { get => arama; set => arama=value; }
        public List<int> SecilenMalzemeIdleri { get; set; } = new List<int>();
        public bool MalzemeSecildi { get => malzemeSecildi; set => malzemeSecildi=value; }

        public Tarifler()
        {
            InitializeComponent();
            tariflerListesi.CellFormatting += new DataGridViewCellFormattingEventHandler(tariflerListesi_StokDurumu);
            tariflerListesi.CellClick+= SilGoruntuleGuncelleClick;
        }
        public void Tarifler_Load(object sender, EventArgs e)
        {
            try
            {
                TariflerRepository tariflerRepo = new TariflerRepository();
                //Console.WriteLine(kategori);
                List<TariflerModeli> tarifler = new List<TariflerModeli>();
                //Console.WriteLine("Tarifler sayfasında kategori"+kategori+"   malzemsy"+malzemeSayisi+"   maliyetaraligi"+tarifMaliyetiAraligi);
                
                tarifler = tariflerRepo.GetTariflerListesi(kategori, malzemeSayisi, tarifMaliyetiAraligi,SecilenMalzemeIdleri,sirala,arama).ToList();

                tariflerListesi.DataSource = tarifler;

                tariflerListesi.Columns["TarifAdi"].HeaderText = "Tarif Adı";
                tariflerListesi.Columns["KategoriAdi"].HeaderText = "Kategori";
                tariflerListesi.Columns["HazirlamaSüresi"].HeaderText = "Hazırlama Süresi";
                tariflerListesi.Columns["TarifMaliyeti"].HeaderText="Tarif Maliyeti ₺";
                tariflerListesi.Columns["StokMaliyeti"].HeaderText="Stok Maliyeti ₺";
                tariflerListesi.Columns["EslesmeYuzdesi"].HeaderText="Eşleşme Yüzdesi %";
                tariflerListesi.Columns["TarifMaliyeti"].Visible=true; 
                tariflerListesi.Columns["StokMaliyeti"].Visible=true; 
                tariflerListesi.Columns["Talimatlar"].Visible = false;
                tariflerListesi.Columns["TarifResmi"].Visible = false;
                tariflerListesi.Columns["TarifID"].Visible = false;
                tariflerListesi.Columns["TarifStokDurumu"].Visible=false;
                tariflerListesi.Columns["EslesmeYuzdesi"].Visible=false;

                if (!tariflerListesi.Columns.Contains("Görüntüle"))
                {
                    DataGridViewImageColumn goruntule = new DataGridViewImageColumn();
                    goruntule.HeaderText = "Görüntüle";
                    goruntule.Name = "Görüntüle";
                    goruntule.Image = Image.FromFile(goruntuleIcon);
                    goruntule.Image = iconBoyut(goruntuleIcon, 24, 24);
                    tariflerListesi.Columns.Add(goruntule);
                }

                if (!tariflerListesi.Columns.Contains("Güncelle"))
                {
                    DataGridViewImageColumn guncelle = new DataGridViewImageColumn();
                    guncelle.HeaderText = "Güncelle";
                    guncelle.Name = "Güncelle";
                    guncelle.Image = Image.FromFile(guncelleIcon);
                    guncelle.Image = iconBoyut(guncelleIcon, 24, 24);
                    tariflerListesi.Columns.Add(guncelle);
                }

                if (!tariflerListesi.Columns.Contains("Sil"))
                {
                    DataGridViewImageColumn sil = new DataGridViewImageColumn();
                    sil.HeaderText = "Sil";
                    sil.Name = "Sil";
                    sil.Image = Image.FromFile(silIcon);
                    sil.Image = iconBoyut(silIcon, 24, 24);
                    tariflerListesi.Columns.Add(sil);
                }
                //Console.WriteLine(tarifler.Count());
                
                tariflerListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tariflerListesi.Columns["TarifAdi"].Width = 160;
                tariflerListesi.Columns["KategoriAdi"].Width = 150;
                tariflerListesi.Columns["HazirlamaSüresi"].Width = 100;
                tariflerListesi.Columns["TarifMaliyeti"].Width = 95;
                tariflerListesi.Columns["StokMaliyeti"].Width = 95;
                tariflerListesi.AllowUserToAddRows = false;
                tariflerListesi.ReadOnly = false;

                tariflerListesi.Columns["TarifAdi"].ReadOnly = true;
                tariflerListesi.Columns["KategoriAdi"].ReadOnly = true;
                tariflerListesi.Columns["HazirlamaSüresi"].ReadOnly = true;
                tariflerListesi.Columns["TarifMaliyeti"].ReadOnly = true; 
                tariflerListesi.Columns["StokMaliyeti"].ReadOnly = true;
                tariflerListesi.Columns["EslesmeYuzdesi"].ReadOnly = true;
                if (malzemeSecildi==true)
                {
                    tariflerListesi.Columns["EslesmeYuzdesi"].Visible = true;
                }
                tariflerListesi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tariflerListesi.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void SilGoruntuleGuncelleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            tariflerListesi.Enabled = false;
            TariflerRepository tarifRep = new TariflerRepository();
            int tarifId = (int)tariflerListesi.Rows[e.RowIndex].Cells["TarifId"].Value;
            if (tariflerListesi.Columns[e.ColumnIndex].Name == "Görüntüle")
            {
                TarifGoruntuleButonunaBasildi?.Invoke(this, tarifId);
                //MessageBox.Show($"Görüntüle butonuna basıldı. Tarif ID: {tarifId}");
            }
            if (tariflerListesi.Columns[e.ColumnIndex].Name == "Güncelle")
            {
               
                TarifGuncelleButonunaBasildi?.Invoke(this, tarifId);
                //MessageBox.Show($"Güncelle butonuna basıldı. Tarif ID: {tarifId}");
            }
            else if (tariflerListesi.Columns[e.ColumnIndex].Name == "Sil")
            {
                
                try
                {
                    tarifRep.TarifSil(tarifId);
                    Tarifler_Load(this, EventArgs.Empty);
                    MessageBox.Show($"Tarif başarıyla silindi. Tarif ID: {tarifId}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
            tariflerListesi.Enabled=true;
        }
        private Image iconBoyut(string imagePath, int width, int height)
        {
            Image originalIcon = Image.FromFile(imagePath);
            Bitmap iconGuncel = new Bitmap(originalIcon, new Size(width, height));
            return iconGuncel;
        }
        private void tariflerListesi_StokDurumu(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int stokDurumuColumnIndex = tariflerListesi.Columns["TarifStokDurumu"].Index;

            if (e.RowIndex >= 0) 
            {
                bool stokDurumuValue = (bool)tariflerListesi.Rows[e.RowIndex].Cells[stokDurumuColumnIndex].Value;
                if (e.ColumnIndex == tariflerListesi.Columns["TarifAdi"].Index ||
                    e.ColumnIndex == tariflerListesi.Columns["KategoriAdi"].Index ||
                    e.ColumnIndex == tariflerListesi.Columns["HazirlamaSüresi"].Index ||
                    e.ColumnIndex == tariflerListesi.Columns["TarifMaliyeti"].Index || 
                    e.ColumnIndex== tariflerListesi.Columns["StokMaliyeti"].Index )
                {
                    if (stokDurumuValue)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(0, 74, 47); 
                        e.CellStyle.SelectionForeColor = Color.FromArgb(0, 74, 47);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(163, 0, 54);
                        e.CellStyle.SelectionForeColor = Color.FromArgb(163, 0, 54);
                    } 
                }
            }
        }
    }
}
