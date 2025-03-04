using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab1tarifrehberiprojesi.Models;
using yazlab1tarifrehberiprojesi.Views;

namespace yazlab1tarifrehberiprojesi
{
    public partial class Form1 : Form
    {
        string arananTarifMalzeme = null;
        private readonly TariflerRepository tariflerRepository;
        private readonly MalzemelerRepository malzemelerRepository;
        private List<int> seciliMalzemeIdleri = new List<int>();
        public class MalzemeItem
        {
            public string MalzemeAdi { get; set; }
            public int MalzemeId { get; set; }

            public override string ToString() => MalzemeAdi;
        }
        public Form1()
        {
            InitializeComponent();
            tariflerRepository = new TariflerRepository();
            malzemelerRepository=new MalzemelerRepository();
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            aramatextbox.Click += TextBox1_Click;
            malzemeler1.MalzemeEkleButonunaBasildi += Malzemeler_ButtonClicked;
            anaSayfa1.YenikategorilereBasildi+= AnaSayfaPanellerClicked;
            anaSayfa1.CorbalaraBasildi+= AnaSayfaPanellerClicked;
            anaSayfa1.SalatalaraBasildi+= AnaSayfaPanellerClicked;
            anaSayfa1.TatlilaraBasildi+= AnaSayfaPanellerClicked;
            anaSayfa1.AtistirmaliklaraBasildi+= AnaSayfaPanellerClicked;
            anaSayfa1.AnaYemeklereBasildi+= AnaSayfaPanellerClicked;
            tarifler1.TarifGoruntuleButonunaBasildi += (s, tarifId) =>
            {
                TarifDetay_ButtonClicked(tarifId);
            };
            tarifler1.TarifGuncelleButonunaBasildi+= (s, tarifId) =>
            {
                TarifGuncelleme_ButtonClicked(s, tarifId);
            };
            malzemeler1.MalzemeGuncelleButonunaBasildi+= (s, malzemeId) =>
            {
                MalzemeGuncelleme_ButtonClicked(s, malzemeId);
            };
            malzemelerEkleSil1.MalzemeEklemeButonuBasildi += TabloGuncelle;
            tarifEkle1.TarifEklemeButonunaBasildi+= TabloGuncelle;
            stokDurumu1.StokDurumuGuncellendi+=TabloGuncelle;
            filtrele.SelectedIndexChanged += filtrele_SelectedIndexChanged;
            malzemeGuncelle1.MalzemeGuncellemeButonunaBasildi += TabloGuncelle;
            malzemeAra.TextChanged += MalzemeAra_TextChanged;
            malzemeListBox.ItemCheck += MalzemeListBox_ItemCheck;


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tarif rehberi uygulamasını kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filtrele.DropDownStyle = ComboBoxStyle.DropDown;
            filtrele.Text = "Filtrele";
            filtrele.Items.Add("Kategori");
            filtrele.Items.Add("Malzeme Sayısı");
            filtrele.Items.Add("Maliyet Aralığı");
            sirala.DropDownStyle = ComboBoxStyle.DropDown;
            sirala.Text ="Sırala";
            sirala.Items.Add("Süre(En Hızlıdan En Yavaşa)");
            sirala.Items.Add("Süre(En Yavaştan En Hızlıya)");
            sirala.Items.Add("Maliyeti Artan");
            sirala.Items.Add("Maliyeti Azalan");
            sirala.Items.Add("Stok Maliyeti Artan");
            sirala.Items.Add("Stok Maliyeti Azalan");
            malzemeListBox.Items.Clear();
            malzemeListBox.CheckOnClick = true;
            malzemeListBox.Height = 0;
            malzemeListBox.Visible = false;
            malzemeAraButon.Visible=false;
            malzemeAraİptal.Visible=false;
            malzemeAra.Click += MalzemeAra_Click;


            var malzemeler = malzemelerRepository.GetMalzemeler();
            foreach (var malzeme in malzemeler)
            {
                MalzemeItem item = new MalzemeItem
                {
                    MalzemeAdi = malzeme.MalzemeAdi,
                    MalzemeId = malzeme.MalzemeId
                };
                malzemeListBox.Items.Add(item);
            }

        }
        private void sirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenSiralama = sirala.SelectedItem.ToString();

            if (secilenSiralama=="Süre(En Yavaştan En Hızlıya)")
            {
                tarifler1.Sirala=1;
            }
            if (secilenSiralama == "Süre(En Hızlıdan En Yavaşa)")
            {
                tarifler1.Sirala=2;
            }
            if (secilenSiralama=="Maliyeti Artan")
            {
                tarifler1.Sirala=3;
            }
            if (secilenSiralama == "Maliyeti Azalan")
            {
                tarifler1.Sirala=4;
            }
            if (secilenSiralama=="Stok Maliyeti Artan")
            {
                tarifler1.Sirala=5;
            }
            if (secilenSiralama == "Stok Maliyeti Azalan")
            {
                tarifler1.Sirala=6;
            }

            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
            malzemeGuncelle1.Visible =false;
            tarifler1.Tarifler_Load(sender, EventArgs.Empty);

        }
        private void filtrele_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFiltreleme = filtrele.SelectedItem.ToString();
            if (secilenFiltreleme=="Filtrele")
            {
                tarifler1.Kategori=null;
                tarifler1.MalzemeSayisi=null;
                tarifler1.TarifMaliyetiAraligi=null;
            }
            if (secilenFiltreleme == "Kategori")
            {
                filtrele.Items.Clear();
                filtrele.Items.Add("Kategori seçiniz...");
                var kategoriler = tariflerRepository.TarifKategorileri().ToList();
                filtrele.Items.AddRange(kategoriler.ToArray());
                filtrele.Items.Add("<< Geri");
                filtrele.SelectedIndex=0;
            }
            var mevcutKategoriler = tariflerRepository.TarifKategorileri().ToList();
            if (mevcutKategoriler.Contains(secilenFiltreleme))
            {
                tarifler1.Kategori=secilenFiltreleme;
            }
            else if (secilenFiltreleme == "Malzeme Sayısı")
            {
                filtrele.Items.Clear();
                filtrele.Items.Add("Malzeme sayısı seçiniz...");
                filtrele.Items.Add("1-5 Malzeme");
                filtrele.Items.Add("5-10 Malzeme");
                filtrele.Items.Add("10 ve üzeri Malzeme");
                filtrele.Items.Add("<< Geri");
                filtrele.SelectedIndex=0;

            }
            if (secilenFiltreleme == "1-5 Malzeme")
            {
                tarifler1.MalzemeSayisi="1-5";

            }
            else if (secilenFiltreleme == "5-10 Malzeme")
            {
                tarifler1.MalzemeSayisi="5-10";


            }
            else if (secilenFiltreleme == "10 ve üzeri Malzeme")
            {
                tarifler1.MalzemeSayisi="10-1000";

            }
           
            else if (secilenFiltreleme == "Maliyet Aralığı")
            {
                filtrele.Items.Clear();
                filtrele.Items.Add("Maliyet aralığı seçiniz...");
                filtrele.Items.Add("0-100₺");
                filtrele.Items.Add("100-200₺");
                filtrele.Items.Add("200₺ ve üzeri");
                filtrele.Items.Add("<< Geri");
                filtrele.SelectedIndex=0;

            }
            else if (secilenFiltreleme == "0-100₺")
            {
                tarifler1.TarifMaliyetiAraligi="0-100";

            }
            else if (secilenFiltreleme == "100-200₺")
            {
                tarifler1.TarifMaliyetiAraligi ="100-200";

            }
            else if (secilenFiltreleme == "200₺ ve üzeri")
            {
                tarifler1.TarifMaliyetiAraligi="200-1000000";

            }
            else if (secilenFiltreleme == "<< Geri")
            {
                filtrele.Items.Clear();
                filtrele.Items.Add("Filtrele");
                filtrele.Items.Add("Kategori");
                filtrele.Items.Add("Malzeme Sayısı");
                filtrele.Items.Add("Maliyet Aralığı");

            }


            //Console.WriteLine("Form1 de kategori"+tarifler1.Kategori+"malzeme"+tarifler1.MalzemeSayisi+"maliyet"+tarifler1.TarifMaliyetiAraligi);
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
            malzemeGuncelle1.Visible= false;
            tarifler1.Tarifler_Load(sender, EventArgs.Empty);


        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            AramaFiltreleSiralaSecimSifirla();
            anaSayfa1.Visible=true;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible =false;
            tarifler1.Visible=false;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;

        }
        private void tarifler_btn_Click(object sender, EventArgs e)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifGuncelle1.Visible=false;
            tarifler1.Tarifler_Load(sender, e);
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;

        }

        private void stokdurumu_btn_Click(object sender, EventArgs e)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=false;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=true;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;

        }

        private void tarifekle_btn_Click(object sender, EventArgs e)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=true;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=false;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;

        }

        private void malzemeler_btn_Click(object sender, EventArgs e)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=false;
            malzemeler1.Visible=true;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(aramatextbox.Text))
            {
                aramatextbox.Text = "";
                aramatextbox.ForeColor = Color.Black;
            }
        }
        private void Malzemeler_ButtonClicked(object sender, EventArgs e)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=true;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=false;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
        }
        private void TarifDetay_ButtonClicked(int tarifId)
        {
            anaSayfa1.Visible = false;
            tarifEkle1.Visible = false;
            malzemelerEkleSil1.Visible = false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible = true;
            malzemeler1.Visible = false;
            stokDurumu1.Visible = false;
            tarifGuncelle1.Visible=false;

            //tarifDetay1.SetTarifId(tarifId);
            var worker = new BackgroundWorker();
            Task.Run(() =>
            {
                Thread.Sleep(30);
                Invoke((MethodInvoker)delegate
                {
                    tarifDetay1.SetTarifId(tarifId);
                    tarifDetay1.UpdateUI();
                    tarifDetay1.Visible = true;
                });
            });
            tarifler1.Visible = false;

        }
        private void TarifGuncelleme_ButtonClicked(object sender, int tarifId)
        {
            anaSayfa1.Visible = false;
            tarifEkle1.Visible = false;
            malzemelerEkleSil1.Visible = false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible = true;
            malzemeler1.Visible = false;
            stokDurumu1.Visible = false;
            tarifGuncelle1.Visible=false;
            tarifDetay1.Visible=false;

            var worker = new BackgroundWorker();
            Task.Run(() =>
            {
                Thread.Sleep(30);
                Invoke((MethodInvoker)delegate
                {
                    tarifGuncelle1.SetTarifId(tarifId);
                    tarifGuncelle1.TarifGuncelle_Load(sender, EventArgs.Empty);
                    tarifGuncelle1.Visible = true;
                });
            });
            tarifler1.Visible = false;

        }
        private void MalzemeGuncelleme_ButtonClicked(object sender, int malzemeId)
        {
            anaSayfa1.Visible = false;
            tarifEkle1.Visible = false;
            malzemelerEkleSil1.Visible = false;
            tarifler1.Visible = false;
            malzemeler1.Visible = true;
            stokDurumu1.Visible = false;
            tarifGuncelle1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible = false;
            var worker = new BackgroundWorker();
            Task.Run(() =>
            {
                Thread.Sleep(30);
                Invoke((MethodInvoker)delegate
                {
                    malzemeGuncelle1.SetMalzemeId(malzemeId);
                    malzemeGuncelle1.MalzemeGuncelle_Load(sender, EventArgs.Empty);
                    malzemeGuncelle1.Visible = true;
                });
            });
            malzemeler1.Visible = false;


        }

        private void TabloGuncelle(object sender, EventArgs e)
        {
            tarifler1.Tarifler_Load(sender, e);
            malzemeler1.Malzemeler_Load(sender, e);
            stokDurumu1.StokDurumu_Load(sender, e);
        }

        private void AnaSayfaPanellerClicked(object sender, string kategori)
        {
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
            tarifler1.Kategori=kategori;

            tarifler1.Tarifler_Load(sender, EventArgs.Empty);
        }

        public TarifDetay TarifDetayControl
        {
            get { return tarifDetay1; }
        }

        private void aramatextbox_TextChanged(object sender, EventArgs e)
        {
            arananTarifMalzeme = aramatextbox.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tarifler1.Arama=arananTarifMalzeme;
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            malzemeGuncelle1.Visible=false;
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;

            tarifler1.Tarifler_Load(sender, EventArgs.Empty);
        }

        public void AramaFiltreleSiralaSecimSifirla()
        {
            tarifler1.Arama=null;
            tarifler1.Kategori=null;
            tarifler1.MalzemeSayisi=null;
            tarifler1.TarifMaliyetiAraligi=null;
            tarifler1.SecilenMalzemeIdleri=null;
            tarifler1.MalzemeSecildi=false;
            filtrele.SelectedIndex=0;
            sirala.SelectedIndex=0;

            aramatextbox.Text="Tarif adı veya malzemeye göre arama.";
            filtrele.Items.Clear();
            filtrele.Items.Add("Filtrele");
            filtrele.Items.Add("Kategori");
            filtrele.Items.Add("Malzeme Sayısı");
            filtrele.Items.Add("Maliyet Aralığı");
            filtrele.SelectedIndex = 0;

            sirala.Items.Clear();
            sirala.Items.Add("Sırala");
            sirala.Items.Add("Süre(En Hızlıdan En Yavaşa)");
            sirala.Items.Add("Süre(En Yavaştan En Hızlıya)");
            sirala.Items.Add("Maliyeti Artan");
            sirala.Items.Add("Maliyeti Azalan");
            sirala.Items.Add("Stok Maliyeti Artan");
            sirala.Items.Add("Stok Maliyeti Azalan");
            sirala.SelectedIndex = 0;
        }

        private void secenekleriTemizle_Click(object sender, EventArgs e)
        {
            AramaFiltreleSiralaSecimSifirla();
            malzemeAraİptal_Click(sender, e);
        }
        private void MalzemeAra_Click(object sender, EventArgs e)
        {
            SetCheckedListBoxHeight(10);
            if (malzemeListBox.Visible!=true)
            {
                malzemeAra.DroppedDown = false;
                malzemeListBox.Visible = true;
                malzemeAraButon.Visible=true;
                malzemeAraİptal.Visible=true;
                malzemeListBox.Location= new System.Drawing.Point(555, 42);
            }
            else
            {
                malzemeAra.DroppedDown = false;
                malzemeListBox.Visible = false;
                malzemeAraButon.Visible=false;
                malzemeAraİptal.Visible=false;
                malzemeListBox.Location= new System.Drawing.Point(555, 42);
            }
        }
        private void SetCheckedListBoxHeight(int numberOfItems)
        {
            int itemHeight = 20;
            malzemeListBox.Height = itemHeight * numberOfItems + malzemeListBox.ItemHeight;
        }

        private void MalzemeAra_TextChanged(object sender, EventArgs e)
        {
            if (!malzemeListBox.Visible && !string.IsNullOrWhiteSpace(malzemeAra.Text))
            {
                malzemeListBox.Visible = true;
                malzemeAraButon.Visible = true;
                malzemeAraİptal.Visible = true;
            }

            malzemeListBox.ItemCheck -= MalzemeListBox_ItemCheck;
            foreach (MalzemeItem item in malzemeListBox.CheckedItems)
            {
                seciliMalzemeIdleri.Add(item.MalzemeId);
            }

            string aramaMetni = malzemeAra.Text.ToLower();
            var malzemeler = malzemelerRepository.GetMalzemeler();
            var yeniMalzemeListesi = malzemeler.Where(malzeme => malzeme.MalzemeAdi.ToLower().Contains(aramaMetni)).Select(malzeme => new MalzemeItem
            {
                MalzemeId = malzeme.MalzemeId,
                MalzemeAdi = malzeme.MalzemeAdi
            }).ToList();

            malzemeListBox.Items.Clear();

            foreach (var item in yeniMalzemeListesi)
            {
                malzemeListBox.Items.Add(item);
            }

            foreach (MalzemeItem item in yeniMalzemeListesi)
            {
                if (seciliMalzemeIdleri.Contains(item.MalzemeId))
                {
                    malzemeListBox.SetItemChecked(malzemeListBox.Items.IndexOf(item), true);
                }
            }

            malzemeListBox.ItemCheck += MalzemeListBox_ItemCheck;
        }
        private void MalzemeListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                malzemeListBox.SetSelected(e.Index, true);
            }
            else
            {
                malzemeListBox.SetSelected(e.Index, false);
            }
        }
        private void malzemeAraButon_Click(object sender, EventArgs e)
        {
            malzemeListBox.Visible = false;
            malzemeAraButon.Visible = false;
            malzemeAraİptal.Visible = false;

            List<int> secilenMalzemeler = new List<int>();
            foreach (var secilenMalzeme in malzemeListBox.CheckedItems)
            {
                if (secilenMalzeme is MalzemeItem item)
                {
                    secilenMalzemeler.Add(item.MalzemeId);
                }
            }

            tarifler1.SecilenMalzemeIdleri = secilenMalzemeler;

            foreach (var malzeme in tarifler1.SecilenMalzemeIdleri)
            {
                Console.WriteLine(malzeme);
            }
            tarifler1.MalzemeSecildi=true;
            anaSayfa1.Visible=false;
            tarifEkle1.Visible=false;
            malzemelerEkleSil1.Visible=false;
            tarifler1.Visible=true;
            malzemeler1.Visible=false;
            stokDurumu1.Visible=false;
            tarifDetay1.Visible=false;
            tarifGuncelle1.Visible=false;
            malzemeGuncelle1.Visible= false;
            tarifler1.Tarifler_Load(sender, EventArgs.Empty);
        }
        private void malzemeAraİptal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < malzemeListBox.Items.Count; i++)
            {
                malzemeListBox.SetItemChecked(i, false);
            }
            malzemeListBox.Visible = false;
            malzemeAraButon.Visible = false;
            malzemeAraİptal.Visible = false;
            tarifler1.MalzemeSecildi=false;
            tarifler1.Tarifler_Load(sender, EventArgs.Empty);
        }

      
    }

}
