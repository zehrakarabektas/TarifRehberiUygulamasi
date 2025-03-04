using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1tarifrehberiprojesi.Models;

namespace yazlab1tarifrehberiprojesi.Views
{
    public partial class StokDurumu : UserControl
    {
        string guncelleIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\guncelle.png";
        public event EventHandler StokDurumuGuncellendi;
        public StokDurumu()
        {
            InitializeComponent();
            stokListesi.CellFormatting += new DataGridViewCellFormattingEventHandler(stokListesi_StokDurumu);
        }

        public void StokDurumu_Load(object sender, EventArgs e)
        {
            try
            {
                MalzemelerRepository malzemelerRepo = new MalzemelerRepository();
                var malzemeler = malzemelerRepo.GetMalzemeler();
                stokListesi.DataSource = malzemeler.ToList();
                stokListesi.Columns["MalzemeAdi"].HeaderText = "Malzeme Adı";
                stokListesi.Columns["ToplamMiktar"].HeaderText = "Toplam Miktar";
                stokListesi.Columns["MalzemeBirim"].HeaderText="Malzeme Birim";
                stokListesi.Columns["BirimFiyat"].Visible=false; ;
                stokListesi.Columns["MalzemeId"].Visible = false;
                stokListesi.Columns["MalzemeDurum"].Visible=false;
                if (!stokListesi.Columns.Contains("Güncelle"))
                {
                    DataGridViewImageColumn guncelle = new DataGridViewImageColumn();
                    guncelle.HeaderText = "Güncelle";
                    guncelle.Name = "Güncelle";
                    guncelle.Image = Image.FromFile(guncelleIcon);
                    guncelle.Image = iconBoyut(guncelleIcon, 24, 24);
                    stokListesi.Columns.Add(guncelle);
                }

                //if (!stokListesi.Columns.Contains("Sil"))
                //{
                //    DataGridViewButtonColumn silColumn = new DataGridViewButtonColumn();
                //    silColumn.HeaderText = "Sil";
                //    silColumn.Name = "Sil";
                //    silColumn.Text = "Sil";
                //    silColumn.UseColumnTextForButtonValue = true;
                //    stokListesi.Columns.Add(silColumn);
                //}

                stokListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                stokListesi.AllowUserToAddRows = false;
                stokListesi.ReadOnly = false;
                stokListesi.Columns["MalzemeAdi"].ReadOnly = true;
                stokListesi.Columns["ToplamMiktar"].ReadOnly = false;
                stokListesi.Columns["MalzemeBirim"].ReadOnly = true;
                stokListesi.CellClick += GuncelleSilClick;
                stokListesi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                stokListesi.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
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

            if (stokListesi.Columns[e.ColumnIndex].Name == "Güncelle")
            {
                int malzemeId = (int)stokListesi.Rows[e.RowIndex].Cells["MalzemeId"].Value;
                var toplamMiktar = stokListesi.Rows[e.RowIndex].Cells["ToplamMiktar"].Value.ToString();
                
                malzemeRep.StokGuncelle(malzemeId, toplamMiktar);
                //MessageBox.Show($"Malzemenin stok durumu başarıyla güncellendi.Malzeme ID: {malzemeId}"); //bos olması durumunda eski deger korunmalı onu yazmalıyım
                StokDurumu_Load(this, EventArgs.Empty);
                StokDurumuGuncellendi?.Invoke(sender, e);

            }
            //else if (stokListesi.Columns[e.ColumnIndex].Name == "Sil")
            //{
            //    int malzemeId = (int)stokListesi.Rows[e.RowIndex].Cells["MalzemeId"].Value;
            //    try
            //    {

            //        malzemeRep.MalzemeSil(malzemeId);
            //        StokDurumu_Load(this, EventArgs.Empty);
            //        MessageBox.Show($"Sil butonuna basıldı. Malzeme ID: {malzemeId}");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message);
            //    }

            //}
        }
        private Image iconBoyut(string imagePath, int width, int height)
        {
            Image originalIcon = Image.FromFile(imagePath);
            Bitmap iconGuncel = new Bitmap(originalIcon, new Size(width, height));
            return iconGuncel;
        }
        private void stokListesi_StokDurumu(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int stokDurumuColumnIndex = stokListesi.Columns["MalzemeDurum"].Index;

            if (e.RowIndex >= 0)
            {
                bool stokDurumuValue = (bool)stokListesi.Rows[e.RowIndex].Cells[stokDurumuColumnIndex].Value;
                if (e.ColumnIndex == stokListesi.Columns["MalzemeAdi"].Index ||
                    e.ColumnIndex == stokListesi.Columns["ToplamMiktar"].Index ||
                    e.ColumnIndex == stokListesi.Columns["MalzemeBirim"].Index)
                {
                    if (stokDurumuValue)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(0, 74, 47);
                        e.CellStyle.SelectionForeColor = Color.FromArgb(17, 63, 40);
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
