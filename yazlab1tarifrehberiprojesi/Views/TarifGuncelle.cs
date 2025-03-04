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

namespace yazlab1tarifrehberiprojesi
{
    public partial class TarifGuncelle : UserControl
    {
        private int tarifId ,malzemeId;
        private string eskiTarifAdi,eskiKategoriAdi,eskiTalimatlar,eskiTarifResmi;
        private int eskiSure;
        private string eskiMalzemeMiktar;
        private string tarifImagePath = "";
        private TariflerRepository tarifRepo;
        private TarifMalzemeIliskiRepository tarifMalzemeRepo;
        private readonly MalzemelerRepository malzemelerRepo; 
        string guncelleIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\guncelle.png";
        string silIcon = @"C:\\Users\\zehra\\source\\repos\\yazlab1tarifrehberiprojesi\\yazlab1tarifrehberiprojesi\\Images\\Icons\\sil.png";
        public void SetTarifId(int tarifId)
        {
            this.tarifId= tarifId;
        }
        public TarifGuncelle()
        {
            InitializeComponent();
            tarifRepo = new TariflerRepository();
            tarifMalzemeRepo = new TarifMalzemeIliskiRepository();
            malzemelerRepo = new MalzemelerRepository();
            malzemeListesi.CellFormatting += new DataGridViewCellFormattingEventHandler(malzemeListesi_StokDurumu);
            malzemeListesi.CellClick += GuncelleSilClick;
        }
        public void TarifGuncelle_Load(object sender, EventArgs e)
        {
            TariflerRepository tarifRepo = new TariflerRepository();
            TariflerModeli tarif = new TariflerModeli();
            tarif=tarifRepo.GetTarifDetay(tarifId);
            var tarifmalzemeleri = tarifMalzemeRepo.GetTarifMalzemeler(tarifId);
            var kategoriler = tarifRepo.TarifKategorileri().ToList();
            //Console.WriteLine(tarifId);
            //Console.WriteLine("Tarif Adı: " + tarif.TarifAdi);
            //Console.WriteLine("Hazırlama Süresi: " + tarif.HazirlamaSüresi);
            //Console.WriteLine("Kategori Adı: " + tarif.KategoriAdi);
            //Console.WriteLine("Maliyet: " + tarif.TarifMaliyeti);

            if (tarif != null)
            {
                //Girilmeyen bir bilgi için eski bilgilerin tutulması saglandı
                eskiTarifAdi = tarif.TarifAdi;
                eskiKategoriAdi = tarif.KategoriAdi;
                eskiSure = tarif.HazirlamaSüresi;
                eskiTalimatlar = tarif.Talimatlar;
                eskiTarifResmi= tarif.TarifResmi;

                tarifAdi_label.Text = string.Empty;
                sure_label.Text = string.Empty;
                kategori_cmbox.Text = string.Empty;
                tarifAdi_label.Size = new Size(200, 50);
                tarifAdi_label.Text = tarif.TarifAdi;
                sure_label.Text = tarif.HazirlamaSüresi.ToString()+" dakika";
                kategoriler.Insert(0, "Yeni Kategori");
                kategori_cmbox.DataSource = kategoriler;
                kategori_cmbox.DropDownStyle = ComboBoxStyle.DropDown;
                if (kategoriler.Contains(tarif.KategoriAdi))
                {
                    kategori_cmbox.SelectedItem = tarif.KategoriAdi; 
                }

                var talimatlar = TalimatlarText(tarif.Talimatlar, 50);
                talimatlar_textbox.Text = string.Join(Environment.NewLine, talimatlar);

                string projeDizini = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string resimDizini = Path.Combine(projeDizini, "Images", "Tarifler");

                if (tarif.TarifResmi != null)
                {
                    string resimYolu = Path.Combine(resimDizini, tarif.TarifResmi);
                    if (File.Exists(resimYolu))
                    {
                        tarifresim_pbox.SizeMode = PictureBoxSizeMode.Zoom;
                        tarifresim_pbox.Image = Image.FromFile(resimYolu);
                    }
                    else
                    {
                        MessageBox.Show("Resim bulunamadı: " + resimYolu);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tarif bulunamadı.");
            }
            MalzemeTablosuGuncelle();
        }
        public void MalzemeTablosuGuncelle()
        {
            try
            {
                var tarifmalzemeleri = tarifMalzemeRepo.GetTarifMalzemeler(tarifId);
                var malzemeler = malzemelerRepo.GetMalzemeler();
                var malzemeAdlari = malzemeler.Select(m => m.MalzemeAdi).ToList();
                malzemeAdlari.Insert(0, "Malzeme Seçiniz");
                malzemead_cmbox.DataSource = malzemeAdlari;
                malzemead_cmbox.DropDownStyle = ComboBoxStyle.DropDownList;
                birim_cmbox.Items.Clear();
                birim_cmbox.Items.Add("Birim");
                birim_cmbox.SelectedIndex = 0;

                malzemeListesi.Columns.Clear();
                malzemeListesi.Columns.Add("MalzemeId", "Malzeme Id");
                malzemeListesi.Columns.Add("Malzeme", "Malzeme Adı");
                malzemeListesi.Columns.Add("Miktar", "Miktar");
                malzemeListesi.Columns.Add("Birim", "Birim");
                malzemeListesi.Columns.Add("StokDurumu", "Stok Durumu");

                foreach (var (malzeme, malzemeId, stokDurumu) in tarifmalzemeleri)
                {
                    int rowIndex = malzemeListesi.Rows.Add();
                    var malzemeBilgileri = malzeme.Split(' ');
                    string miktar = malzemeBilgileri[0];
                    string birim = malzemeBilgileri[1];
                    string malzemeAdi = string.Join(" ", malzemeBilgileri.Skip(2));

                    malzemeListesi.Rows[rowIndex].Cells["MalzemeId"].Value = malzemeId;
                    malzemeListesi.Rows[rowIndex].Cells["Malzeme"].Value = malzemeAdi;
                    malzemeListesi.Rows[rowIndex].Cells["Miktar"].Value = miktar;
                    malzemeListesi.Rows[rowIndex].Cells["Birim"].Value = birim;
                    malzemeListesi.Rows[rowIndex].Cells["StokDurumu"].Value = stokDurumu;

                }
                malzemeListesi.Columns["StokDurumu"].Visible = false;
                malzemeListesi.Columns["MalzemeId"].Visible = false;

                if (!malzemeListesi.Columns.Contains("Güncelle"))
                {
                    DataGridViewImageColumn guncelle = new DataGridViewImageColumn();
                    guncelle.HeaderText = "Güncelle";
                    guncelle.Name = "Güncelle";
                    guncelle.Image = Image.FromFile(guncelleIcon);
                    guncelle.Image = iconBoyut(guncelleIcon, 24, 24);
                    malzemeListesi.Columns.Add(guncelle);
                }

                if (!malzemeListesi.Columns.Contains("Sil"))
                {
                    DataGridViewImageColumn sil = new DataGridViewImageColumn();
                    sil.HeaderText = "Sil";
                    sil.Name = "Sil";
                    sil.Image = Image.FromFile(silIcon);
                    sil.Image = iconBoyut(silIcon, 24, 24);
                    malzemeListesi.Columns.Add(sil);
                }
                malzemeListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                malzemeListesi.AllowUserToAddRows = false;
                malzemeListesi.ReadOnly = false;

                malzemeListesi.Columns["Malzeme"].ReadOnly = true;
                malzemeListesi.Columns["Miktar"].ReadOnly = false;
                malzemeListesi.Columns["Birim"].ReadOnly = true;
                malzemeListesi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                malzemeListesi.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme adları yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private List<string> TalimatlarText(string text, int maxLineLength)
        {
            List<string> satir = new List<string>();
            if (string.IsNullOrWhiteSpace(text))
            {
                return satir; 
            }
            while (text.Length > maxLineLength)
            {
                int lastSpaceIndex = text.LastIndexOf(' ', maxLineLength);
                if (lastSpaceIndex == -1) lastSpaceIndex = maxLineLength; 

                satir.Add("    "+text.Substring(0, lastSpaceIndex).Trim());

                text = text.Substring(lastSpaceIndex).Trim();
            }

            if (text.Length > 0)
                satir.Add("    "+text.Trim());

            return satir;
        }

        private void resim_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter="Image Files(*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    tarifImagePath=dosya.FileName;
                    tarifresim_pbox.ImageLocation=tarifImagePath;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void malzemead_cmbox_SelectedIndexChanged(object sender, EventArgs e)
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
        private void GuncelleSilClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            TarifMalzemeIliskiRepository tarifMalzemeRep = new TarifMalzemeIliskiRepository();
            malzemeListesi.Enabled = false;
            int malzemeId = (int)malzemeListesi.Rows[e.RowIndex].Cells["MalzemeId"].Value;

            if (malzemeListesi.Columns[e.ColumnIndex].Name == "Güncelle")
            { 
                var toplamMiktar = malzemeListesi.Rows[e.RowIndex].Cells["Miktar"].Value.ToString();
                
                TarifMalzemeIliskisiModeli guncellenecektarif = new TarifMalzemeIliskisiModeli
                {
                    TarifID=tarifId,
                    MalzemeID = malzemeId,
                    MalzemeMiktar= float.Parse(toplamMiktar)
                };
                tarifMalzemeRep.IliskiGuncelle(guncellenecektarif);
                MalzemeTablosuGuncelle();
                MessageBox.Show($"Tarif malzemesinin miktarı başarıyla güncellendi.Malzeme ID: {malzemeId}"); //bos olması durumunda eski deger korunmalı onu yazmalıyım
            }
            else if (malzemeListesi.Columns[e.ColumnIndex].Name == "Sil")
            {
                try
                {
                    tarifMalzemeRep.IliskiSil(tarifId,malzemeId);
                    MalzemeTablosuGuncelle();
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
            int stokDurumuColumnIndex = malzemeListesi.Columns["StokDurumu"].Index;

            var stokDurumuCell = malzemeListesi.Rows[e.RowIndex].Cells[stokDurumuColumnIndex].Value;

            if (stokDurumuCell != null && stokDurumuCell is bool stokDurumuValue)
            {
                if (e.ColumnIndex == malzemeListesi.Columns["Malzeme"].Index ||
                    e.ColumnIndex == malzemeListesi.Columns["Miktar"].Index ||
                    e.ColumnIndex == malzemeListesi.Columns["Birim"].Index)
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

        private void tarifguncelle_btn_Click(object sender, EventArgs e)
        {
            
            string tarifAdi = tarifAdi_label.Text;
            string kategori = kategori_cmbox.Text;
            int hazirlamaSuresi;
            if (!int.TryParse(sure_label.Text.Replace(" dakika", ""), out hazirlamaSuresi))
            {
                MessageBox.Show("Lütfen geçerli bir hazırlama süresi giriniz.");
                return;
            }

            string talimatlar = talimatlar_textbox.Text;
            string tarifResmi = tarifImagePath;

            tarifAdi = string.IsNullOrWhiteSpace(tarifAdi) ? eskiTarifAdi : tarifAdi;
            kategori = string.IsNullOrWhiteSpace(kategori) ? eskiKategoriAdi : kategori;
            hazirlamaSuresi = hazirlamaSuresi == 0 ? eskiSure : hazirlamaSuresi;
            talimatlar = string.IsNullOrWhiteSpace(talimatlar) ? eskiTalimatlar : talimatlar;
            tarifResmi = string.IsNullOrWhiteSpace(tarifResmi) ? eskiTarifResmi : tarifResmi;


            TariflerModeli tarifModeli = new TariflerModeli
            {
                TarifAdi = tarifAdi,
                KategoriAdi = kategori,
                HazirlamaSüresi = hazirlamaSuresi,
                Talimatlar = talimatlar,
                TarifResmi = !string.IsNullOrEmpty(tarifResmi) ? Path.GetFileName(tarifResmi) : null
            };
            try
            {
                tarifRepo.TarifGuncelle(tarifModeli, tarifId); 
                MessageBox.Show("Tarif başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarif güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void malzeme_btn_Click(object sender, EventArgs e)
        {
            string malzemeAdi = malzemead_cmbox.SelectedItem?.ToString();
            string birim = birim_cmbox.SelectedItem?.ToString();
            string miktar = miktar_txt.Text;
            
            if (!string.IsNullOrEmpty(malzemeAdi) && malzemeAdi != "Malzeme Seçiniz")
            {
                malzemeId = malzemelerRepo.GetMalzemeId(malzemeAdi);

                if (malzemeId != -1)
                {
                    //MessageBox.Show($"Seçilen Malzeme ID: {malzemeId}");
                    if (float.TryParse(miktar, out float miktarFloat))
                    {
                        var tarifMalzemeModeli = new TarifMalzemeIliskisiModeli
                        {
                            TarifID = tarifId,
                            MalzemeID = malzemeId,
                            MalzemeMiktar = miktarFloat
                        };
                        tarifMalzemeRepo.IliskiEkle(tarifMalzemeModeli);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
                    }
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
            MalzemeTablosuGuncelle();
            miktar_txt.Clear();
            malzemead_cmbox.SelectedIndex = 0; 
            birim_cmbox.SelectedIndex = 0;


        }
        private void kategori_cmbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (kategori_cmbox.SelectedItem != null && kategori_cmbox.SelectedItem.ToString() == "Yeni Kategori")
            {
                kategori_cmbox.Text = "";
                kategori_cmbox.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }


    }
    
}
