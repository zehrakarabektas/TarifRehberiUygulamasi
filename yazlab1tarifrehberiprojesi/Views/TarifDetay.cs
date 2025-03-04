using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1proje1.Models;
using yazlab1tarifrehberiprojesi.Models;

namespace yazlab1tarifrehberiprojesi.Views
{
    public partial class TarifDetay : UserControl
    {
        private int tarifId;
        private TariflerRepository tarifRepo;
        private TarifMalzemeIliskiRepository tarifMalzemeRepo;
        
        public TarifDetay()
        {
            InitializeComponent();
            tarifRepo = new TariflerRepository();
            tarifMalzemeRepo = new TarifMalzemeIliskiRepository();
            this.Load += TarifDetay_Load;

        }
        public void SetTarifId(int tarifId)
        {
            this.tarifId= tarifId;
            
        }
        public void TarifDetay_Load(object sender, EventArgs e)
        {
            Console.WriteLine("LOAD:"+tarifId);
            
        }
        public void UpdateUI()
        {
            
            TariflerRepository tarifRepo = new TariflerRepository();
            TariflerModeli tarif = new TariflerModeli();
            tarif=tarifRepo.GetTarifDetay(tarifId);
            var tarifmalzemeleri = tarifMalzemeRepo.GetTarifMalzemeler(tarifId);
            //Console.WriteLine(tarifId);
            //Console.WriteLine("Tarif Adı: " + tarif.TarifAdi);
            //Console.WriteLine("Hazırlama Süresi: " + tarif.HazirlamaSüresi);
            //Console.WriteLine("Kategori Adı: " + tarif.KategoriAdi);
            //Console.WriteLine("Maliyet: " + tarif.TarifMaliyeti);
           
            if (tarif != null)
            {
                tarifAdi_label.Text = string.Empty;
                sure_label.Text = string.Empty;
                kategori_label.Text = string.Empty;
                stokMaliyet_label.Text = string.Empty;
                talimatlar_list.Items.Clear();
                
                //talimatlar_list.Items.Add("");
                tarifAdi_label.Size = new Size(200, 50);
                tarifAdi_label.Text = tarif.TarifAdi;
                sure_label.Text = tarif.HazirlamaSüresi.ToString()+" dakika";
                kategori_label.Text = tarif.KategoriAdi;
                stokMaliyet_label.Text=tarif.StokMaliyeti.ToString()+" ₺";
                toplamMaliyet_label.Text=tarif.TarifMaliyeti.ToString()+" ₺";
                
                //Console.WriteLine(tarifAdi_label.Text + sure_label.Text+kategori_label.Text);
                //Console.WriteLine("Tarif Adı: " + tarifAdi_label.ToString());
                //Console.WriteLine("Hazırlama Süresi: " + sure_label.ToString());
                var talimatlar = TalimatlarText(tarif.Talimatlar, 100); 
                foreach (var talimat in talimatlar)
                {
                    talimatlar_list.Items.Add(talimat);
                }
                malzemelerList.Items.Clear();
                malzemelerList.ScrollAlwaysVisible = true;


                foreach (var (malzeme,malzemeId, stokDurumu) in tarifmalzemeleri)
                {
                    malzemelerList.Items.Add(new { malzeme = malzeme,malzemeId=malzemeId, stokDurumu = stokDurumu });
                }
                malzemeRenklendir(malzemelerList);

                string projeDizini = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string resimDizini = Path.Combine(projeDizini, "Images", "Tarifler");

                if (tarif.TarifResmi != null)
                {
                    string resimYolu = Path.Combine(resimDizini, tarif.TarifResmi); 
                    if (File.Exists(resimYolu)) 
                    {
                        resim_pbox.SizeMode = PictureBoxSizeMode.Zoom;
                        resim_pbox.Image = Image.FromFile(resimYolu); 
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
        private void malzemeRenklendir(ListBox malzemeList)
        {
            SolidBrush stokVarBrush = new SolidBrush(Color.FromArgb(0, 74, 47));
            SolidBrush stokYokBrush = new SolidBrush(Color.FromArgb(163, 0, 54));
            Font listBoxFont = new Font(malzemelerList.Font, FontStyle.Regular);

            malzemelerList.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;
                dynamic item = malzemelerList.Items[e.Index];
                e.DrawBackground();

                SolidBrush brush = item.stokDurumu ? stokVarBrush : stokYokBrush;

                e.Graphics.DrawString("  • " + item.malzeme, listBoxFont, brush, e.Bounds);

                e.DrawFocusRectangle();
            };
        }

       
    }
}


       