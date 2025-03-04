using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1tarifrehberiprojesi.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;


namespace yazlab1tarifrehberiprojesi.Views
{
    public partial class Malzemeler : UserControl
    {
        public event EventHandler MalzemeEkleButonunaBasildi;
        public event EventHandler<int> MalzemeGuncelleButonunaBasildi;
        string guncelleGoruntu = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\guncelle.png";
        string silGoruntu = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\sil.png";
        public Malzemeler()
        {
            InitializeComponent();
            malzemeListesi.CellFormatting += new DataGridViewCellFormattingEventHandler(malzemeListesi_StokDurumu);
            malzemeListesi.CellClick += GuncelleSilClick;
        }

        private void malzemeekle_Click(object sender, EventArgs e)
        {
            MalzemeEkleButonunaBasildi?.Invoke(this, EventArgs.Empty);
        }

        public void Malzemeler_Load(object sender, EventArgs e)
        {
            try
            {
                MalzemelerRepository malzemelerRepo = new MalzemelerRepository();
                var malzemeler = malzemelerRepo.GetMalzemeler();
                malzemeListesi.DataSource = malzemeler.ToList();
                malzemeListesi.Columns["MalzemeAdi"].HeaderText = "Malzeme Adı";
                malzemeListesi.Columns["MalzemeBirim"].HeaderText = "Malzeme Birim";
                malzemeListesi.Columns["BirimFiyat"].HeaderText = "Birim Fiyatı (₺)";
                malzemeListesi.Columns["MalzemeId"].Visible = false;
                malzemeListesi.Columns["ToplamMiktar"].Visible = false;
                malzemeListesi.Columns["MalzemeDurum"].Visible=false;
                if (!malzemeListesi.Columns.Contains("Güncelle"))
                {
                    DataGridViewImageColumn guncelle = new DataGridViewImageColumn();
                    guncelle.HeaderText = "Güncelle";
                    guncelle.Name = "Güncelle";
                    guncelle.Image = Image.FromFile(guncelleGoruntu);
                    guncelle.Image = iconBoyut(guncelleGoruntu, 24, 24);
                    malzemeListesi.Columns.Add(guncelle);
                }

                if (!malzemeListesi.Columns.Contains("Sil"))
                {
                    DataGridViewImageColumn sil = new DataGridViewImageColumn();
                    sil.HeaderText = "Sil";
                    sil.Name = "Sil";
                    sil.Image = Image.FromFile(silGoruntu);
                    sil.Image = iconBoyut(silGoruntu, 24, 24);
                    malzemeListesi.Columns.Add(sil);
                }

                malzemeListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                malzemeListesi.AllowUserToAddRows = false;
                malzemeListesi.ReadOnly = false; 
                malzemeListesi.Columns["MalzemeAdi"].ReadOnly = true;    
                malzemeListesi.Columns["ToplamMiktar"].ReadOnly = true; 
                malzemeListesi.Columns["BirimFiyat"].ReadOnly = true;
                malzemeListesi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                malzemeListesi.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void GuncelleSilClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MalzemelerRepository malzemeRep = new MalzemelerRepository();
            malzemeListesi.Enabled = false;
            int malzemeId = (int)malzemeListesi.Rows[e.RowIndex].Cells["MalzemeId"].Value;
            if (malzemeListesi.Columns[e.ColumnIndex].Name == "Güncelle")
            {
                MalzemeGuncelleButonunaBasildi?.Invoke(this, malzemeId);
                MessageBox.Show($"Güncelle butonuna basıldı. Malzeme ID: {malzemeId}");
            }
            if (malzemeListesi.Columns[e.ColumnIndex].Name == "Sil")
            {
                try
                {
                    malzemeRep.MalzemeSil(malzemeId);
                    Malzemeler_Load(this, EventArgs.Empty);
                    MessageBox.Show($"Sil butonuna basıldı. Malzeme ID: {malzemeId}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
                
            }
            malzemeListesi.Enabled = true;
        }
        private Image iconBoyut(string imagePath, int width, int height)
        {
            Image originalIcon = Image.FromFile(imagePath);
            Bitmap iconGuncel = new Bitmap(originalIcon, new Size(width, height));
            return iconGuncel;
        }
        private void malzemeListesi_StokDurumu(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int stokDurumuColumnIndex = malzemeListesi.Columns["MalzemeDurum"].Index;

            if (e.RowIndex >= 0)
            {
                bool stokDurumuValue = (bool)malzemeListesi.Rows[e.RowIndex].Cells[stokDurumuColumnIndex].Value;
                if (e.ColumnIndex == malzemeListesi.Columns["MalzemeAdi"].Index ||
                    e.ColumnIndex == malzemeListesi.Columns["MalzemeBirim"].Index ||
                    e.ColumnIndex == malzemeListesi.Columns["BirimFiyat"].Index)
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
