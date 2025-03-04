using System.Windows.Forms;

namespace yazlab1tarifrehberiprojesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.secenekleriTemizle = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.malzemeler_btn = new System.Windows.Forms.Button();
            this.tarifekle_btn = new System.Windows.Forms.Button();
            this.stokdurumu_btn = new System.Windows.Forms.Button();
            this.tarifler_btn = new System.Windows.Forms.Button();
            this.anasayfa_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.malzemeAraİptal = new System.Windows.Forms.Button();
            this.malzemeAraButon = new System.Windows.Forms.Button();
            this.anaSayfa1 = new yazlab1tarifrehberiprojesi.Views.AnaSayfa();
            this.malzemeGuncelle1 = new yazlab1tarifrehberiprojesi.MalzemeGuncelle();
            this.tarifGuncelle1 = new yazlab1tarifrehberiprojesi.TarifGuncelle();
            this.tarifDetay1 = new yazlab1tarifrehberiprojesi.Views.TarifDetay();
            this.stokDurumu1 = new yazlab1tarifrehberiprojesi.Views.StokDurumu();
            this.malzemeler1 = new yazlab1tarifrehberiprojesi.Views.Malzemeler();
            this.tarifler1 = new yazlab1tarifrehberiprojesi.Views.Tarifler();
            this.malzemelerEkleSil1 = new yazlab1tarifrehberiprojesi.Views.MalzemelerEkleSil();
            this.tarifEkle1 = new yazlab1tarifrehberiprojesi.Views.TarifEkle();
            this.aramavekapatmapaneli = new System.Windows.Forms.Panel();
            this.artanPanel1 = new artanpanel.ArtanPanel();
            this.malzemeAra = new System.Windows.Forms.ComboBox();
            this.sirala = new System.Windows.Forms.ComboBox();
            this.artanPanel2 = new artanpanel.ArtanPanel();
            this.aramatextbox = new System.Windows.Forms.TextBox();
            this.filtrele = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.malzemeListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.secenekleriTemizle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.aramavekapatmapaneli.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 200;
            this.toolTip.ShowAlways = true;
            // 
            // secenekleriTemizle
            // 
            this.secenekleriTemizle.BackColor = System.Drawing.Color.Transparent;
            this.secenekleriTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secenekleriTemizle.Image = ((System.Drawing.Image)(resources.GetObject("secenekleriTemizle.Image")));
            this.secenekleriTemizle.Location = new System.Drawing.Point(1059, 2);
            this.secenekleriTemizle.Name = "secenekleriTemizle";
            this.secenekleriTemizle.Size = new System.Drawing.Size(57, 50);
            this.secenekleriTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secenekleriTemizle.TabIndex = 8;
            this.secenekleriTemizle.TabStop = false;
            this.toolTip.SetToolTip(this.secenekleriTemizle, "Seçimleri Temizle");
            this.secenekleriTemizle.Click += new System.EventHandler(this.secenekleriTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 823);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.malzemeler_btn);
            this.panel2.Controls.Add(this.tarifekle_btn);
            this.panel2.Controls.Add(this.stokdurumu_btn);
            this.panel2.Controls.Add(this.tarifler_btn);
            this.panel2.Controls.Add(this.anasayfa_btn);
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 349);
            this.panel2.TabIndex = 1;
            // 
            // malzemeler_btn
            // 
            this.malzemeler_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.malzemeler_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.malzemeler_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.malzemeler_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.malzemeler_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.malzemeler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.malzemeler_btn.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malzemeler_btn.Location = new System.Drawing.Point(0, 171);
            this.malzemeler_btn.Name = "malzemeler_btn";
            this.malzemeler_btn.Size = new System.Drawing.Size(300, 50);
            this.malzemeler_btn.TabIndex = 4;
            this.malzemeler_btn.Text = "Malzemeler";
            this.malzemeler_btn.UseVisualStyleBackColor = false;
            this.malzemeler_btn.Click += new System.EventHandler(this.malzemeler_btn_Click);
            // 
            // tarifekle_btn
            // 
            this.tarifekle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.tarifekle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarifekle_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifekle_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifekle_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarifekle_btn.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifekle_btn.Location = new System.Drawing.Point(0, 115);
            this.tarifekle_btn.Name = "tarifekle_btn";
            this.tarifekle_btn.Size = new System.Drawing.Size(300, 50);
            this.tarifekle_btn.TabIndex = 3;
            this.tarifekle_btn.Text = "Tarif Ekle";
            this.tarifekle_btn.UseVisualStyleBackColor = false;
            this.tarifekle_btn.Click += new System.EventHandler(this.tarifekle_btn_Click);
            // 
            // stokdurumu_btn
            // 
            this.stokdurumu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.stokdurumu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stokdurumu_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.stokdurumu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.stokdurumu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.stokdurumu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stokdurumu_btn.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokdurumu_btn.Location = new System.Drawing.Point(0, 227);
            this.stokdurumu_btn.Name = "stokdurumu_btn";
            this.stokdurumu_btn.Size = new System.Drawing.Size(300, 50);
            this.stokdurumu_btn.TabIndex = 2;
            this.stokdurumu_btn.Text = "Stok Durumu";
            this.stokdurumu_btn.UseVisualStyleBackColor = false;
            this.stokdurumu_btn.Click += new System.EventHandler(this.stokdurumu_btn_Click);
            // 
            // tarifler_btn
            // 
            this.tarifler_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.tarifler_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarifler_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifler_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifler_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.tarifler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarifler_btn.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifler_btn.Location = new System.Drawing.Point(0, 59);
            this.tarifler_btn.Name = "tarifler_btn";
            this.tarifler_btn.Size = new System.Drawing.Size(300, 50);
            this.tarifler_btn.TabIndex = 1;
            this.tarifler_btn.Text = "Tarifler";
            this.tarifler_btn.UseVisualStyleBackColor = false;
            this.tarifler_btn.Click += new System.EventHandler(this.tarifler_btn_Click);
            // 
            // anasayfa_btn
            // 
            this.anasayfa_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.anasayfa_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfa_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.anasayfa_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.anasayfa_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(165)))), ((int)(((byte)(180)))));
            this.anasayfa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfa_btn.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anasayfa_btn.ForeColor = System.Drawing.Color.Black;
            this.anasayfa_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anasayfa_btn.Location = new System.Drawing.Point(0, 0);
            this.anasayfa_btn.Name = "anasayfa_btn";
            this.anasayfa_btn.Size = new System.Drawing.Size(300, 53);
            this.anasayfa_btn.TabIndex = 0;
            this.anasayfa_btn.Text = "Ana Sayfa";
            this.anasayfa_btn.UseVisualStyleBackColor = false;
            this.anasayfa_btn.Click += new System.EventHandler(this.anasayfa_btn_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(259, 245);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.malzemeAraİptal);
            this.panel3.Controls.Add(this.malzemeAraButon);
            this.panel3.Controls.Add(this.anaSayfa1);
            this.panel3.Controls.Add(this.malzemeGuncelle1);
            this.panel3.Controls.Add(this.tarifGuncelle1);
            this.panel3.Controls.Add(this.tarifDetay1);
            this.panel3.Controls.Add(this.stokDurumu1);
            this.panel3.Controls.Add(this.malzemeler1);
            this.panel3.Controls.Add(this.tarifler1);
            this.panel3.Controls.Add(this.malzemelerEkleSil1);
            this.panel3.Controls.Add(this.tarifEkle1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 750);
            this.panel3.TabIndex = 3;
            // 
            // malzemeAraİptal
            // 
            this.malzemeAraİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeAraİptal.Location = new System.Drawing.Point(535, 237);
            this.malzemeAraİptal.Name = "malzemeAraİptal";
            this.malzemeAraİptal.Size = new System.Drawing.Size(96, 29);
            this.malzemeAraİptal.TabIndex = 15;
            this.malzemeAraİptal.Text = "İptal Et";
            this.malzemeAraİptal.UseVisualStyleBackColor = true;
            this.malzemeAraİptal.Click += new System.EventHandler(this.malzemeAraİptal_Click);
            // 
            // malzemeAraButon
            // 
            this.malzemeAraButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeAraButon.Location = new System.Drawing.Point(439, 237);
            this.malzemeAraButon.Name = "malzemeAraButon";
            this.malzemeAraButon.Size = new System.Drawing.Size(96, 29);
            this.malzemeAraButon.TabIndex = 14;
            this.malzemeAraButon.Text = "Ara";
            this.malzemeAraButon.UseVisualStyleBackColor = true;
            this.malzemeAraButon.Click += new System.EventHandler(this.malzemeAraButon_Click);
            // 
            // anaSayfa1
            // 
            this.anaSayfa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaSayfa1.Location = new System.Drawing.Point(0, 0);
            this.anaSayfa1.Name = "anaSayfa1";
            this.anaSayfa1.Size = new System.Drawing.Size(1200, 750);
            this.anaSayfa1.TabIndex = 13;
            // 
            // malzemeGuncelle1
            // 
            this.malzemeGuncelle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.malzemeGuncelle1.Location = new System.Drawing.Point(0, 0);
            this.malzemeGuncelle1.Name = "malzemeGuncelle1";
            this.malzemeGuncelle1.Size = new System.Drawing.Size(1200, 750);
            this.malzemeGuncelle1.TabIndex = 12;
            // 
            // tarifGuncelle1
            // 
            this.tarifGuncelle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarifGuncelle1.Location = new System.Drawing.Point(0, 0);
            this.tarifGuncelle1.Name = "tarifGuncelle1";
            this.tarifGuncelle1.Size = new System.Drawing.Size(1200, 750);
            this.tarifGuncelle1.TabIndex = 10;
            // 
            // tarifDetay1
            // 
            this.tarifDetay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarifDetay1.Location = new System.Drawing.Point(0, 0);
            this.tarifDetay1.Name = "tarifDetay1";
            this.tarifDetay1.Size = new System.Drawing.Size(1200, 750);
            this.tarifDetay1.TabIndex = 9;
            // 
            // stokDurumu1
            // 
            this.stokDurumu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokDurumu1.Location = new System.Drawing.Point(0, 0);
            this.stokDurumu1.Name = "stokDurumu1";
            this.stokDurumu1.Size = new System.Drawing.Size(1200, 750);
            this.stokDurumu1.TabIndex = 7;
            // 
            // malzemeler1
            // 
            this.malzemeler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.malzemeler1.Location = new System.Drawing.Point(0, 0);
            this.malzemeler1.Name = "malzemeler1";
            this.malzemeler1.Size = new System.Drawing.Size(1200, 750);
            this.malzemeler1.TabIndex = 5;
            // 
            // tarifler1
            // 
            this.tarifler1.Arama = null;
            this.tarifler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarifler1.Filtrele = 0;
            this.tarifler1.Kategori = null;
            this.tarifler1.Location = new System.Drawing.Point(0, 0);
            this.tarifler1.MalzemeSayisi = null;
            this.tarifler1.MalzemeSecildi = false;
            this.tarifler1.Name = "tarifler1";
            this.tarifler1.SecilenMalzemeIdleri = null;
            this.tarifler1.Sirala = 0;
            this.tarifler1.Size = new System.Drawing.Size(1200, 750);
            this.tarifler1.TabIndex = 4;
            this.tarifler1.TarifMaliyetiAraligi = null;
            // 
            // malzemelerEkleSil1
            // 
            this.malzemelerEkleSil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.malzemelerEkleSil1.Location = new System.Drawing.Point(0, 0);
            this.malzemelerEkleSil1.MalzemeId = 0;
            this.malzemelerEkleSil1.Name = "malzemelerEkleSil1";
            this.malzemelerEkleSil1.Size = new System.Drawing.Size(1200, 750);
            this.malzemelerEkleSil1.TabIndex = 2;
            // 
            // tarifEkle1
            // 
            this.tarifEkle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarifEkle1.Location = new System.Drawing.Point(0, 0);
            this.tarifEkle1.Name = "tarifEkle1";
            this.tarifEkle1.Size = new System.Drawing.Size(1200, 750);
            this.tarifEkle1.TabIndex = 1;
            // 
            // aramavekapatmapaneli
            // 
            this.aramavekapatmapaneli.Controls.Add(this.artanPanel1);
            this.aramavekapatmapaneli.Controls.Add(this.exitButton);
            this.aramavekapatmapaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.aramavekapatmapaneli.Location = new System.Drawing.Point(300, 0);
            this.aramavekapatmapaneli.Name = "aramavekapatmapaneli";
            this.aramavekapatmapaneli.Size = new System.Drawing.Size(1200, 73);
            this.aramavekapatmapaneli.TabIndex = 2;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.malzemeAra);
            this.artanPanel1.Controls.Add(this.secenekleriTemizle);
            this.artanPanel1.Controls.Add(this.sirala);
            this.artanPanel1.Controls.Add(this.artanPanel2);
            this.artanPanel1.Controls.Add(this.filtrele);
            this.artanPanel1.Controls.Add(this.searchButton);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.artanPanel1.Location = new System.Drawing.Point(6, 12);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1119, 55);
            this.artanPanel1.TabIndex = 5;
            // 
            // malzemeAra
            // 
            this.malzemeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.malzemeAra.FormattingEnabled = true;
            this.malzemeAra.Location = new System.Drawing.Point(434, 14);
            this.malzemeAra.Name = "malzemeAra";
            this.malzemeAra.Size = new System.Drawing.Size(191, 26);
            this.malzemeAra.TabIndex = 10;
            this.malzemeAra.Text = "Malzeme Seçiniz.";
            // 
            // sirala
            // 
            this.sirala.Cursor = System.Windows.Forms.Cursors.Default;
            this.sirala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sirala.FormattingEnabled = true;
            this.sirala.Location = new System.Drawing.Point(839, 14);
            this.sirala.Name = "sirala";
            this.sirala.Size = new System.Drawing.Size(214, 26);
            this.sirala.TabIndex = 7;
            this.sirala.SelectedIndexChanged += new System.EventHandler(this.sirala_SelectedIndexChanged);
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.aramatextbox);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.Transparent;
            this.artanPanel2.Location = new System.Drawing.Point(9, 11);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(356, 35);
            this.artanPanel2.TabIndex = 6;
            // 
            // aramatextbox
            // 
            this.aramatextbox.BackColor = System.Drawing.Color.White;
            this.aramatextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aramatextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramatextbox.Location = new System.Drawing.Point(14, 9);
            this.aramatextbox.Name = "aramatextbox";
            this.aramatextbox.Size = new System.Drawing.Size(458, 20);
            this.aramatextbox.TabIndex = 1;
            this.aramatextbox.Text = "Tarif adı veya malzemeye göre arama.";
            this.aramatextbox.TextChanged += new System.EventHandler(this.aramatextbox_TextChanged);
            // 
            // filtrele
            // 
            this.filtrele.Cursor = System.Windows.Forms.Cursors.Default;
            this.filtrele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrele.FormattingEnabled = true;
            this.filtrele.Location = new System.Drawing.Point(631, 14);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(202, 26);
            this.filtrele.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(371, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 50);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 5;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.pictureBox2_Click);
            toolTip.SetToolTip(this.searchButton, "Arama Yap");
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1131, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 50);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.pictureBox1_Click_1);
            toolTip.SetToolTip(this.exitButton, "Kapat");
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Filtrele";
            // 
            // malzemeListBox
            // 
            this.malzemeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.malzemeListBox.FormattingEnabled = true;
            this.malzemeListBox.Location = new System.Drawing.Point(740, 46);
            this.malzemeListBox.Name = "malzemeListBox";
            this.malzemeListBox.Size = new System.Drawing.Size(191, 194);
            this.malzemeListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 823);
            this.Controls.Add(this.malzemeListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.aramavekapatmapaneli);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secenekleriTemizle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.aramavekapatmapaneli.ResumeLayout(false);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button malzemeler_btn;
        private System.Windows.Forms.Button tarifekle_btn;
        private System.Windows.Forms.Button stokdurumu_btn;
        private System.Windows.Forms.Button tarifler_btn;
        private System.Windows.Forms.Button anasayfa_btn;
        private System.Windows.Forms.Panel panel3;
        private Views.TarifEkle tarifEkle1;
        private Views.MalzemelerEkleSil malzemelerEkleSil1;
        private System.Windows.Forms.Panel aramavekapatmapaneli;
        private System.Windows.Forms.PictureBox exitButton;
        public System.Windows.Forms.TextBox aramatextbox;
        private System.Windows.Forms.ComboBox filtrele;
        private System.Windows.Forms.PictureBox searchButton;
        private artanpanel.ArtanPanel artanPanel1;
        private artanpanel.ArtanPanel artanPanel2;
        private Views.Tarifler tarifler1;
        private Views.Malzemeler malzemeler1;
        private Views.StokDurumu stokDurumu1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Views.TarifDetay tarifDetay1;
        private System.Windows.Forms.ComboBox sirala;
        private TarifGuncelle tarifGuncelle1;
        private MalzemeGuncelle malzemeGuncelle1;
        private Views.AnaSayfa anaSayfa1;
        private System.Windows.Forms.PictureBox secenekleriTemizle;
        private System.Windows.Forms.CheckedListBox malzemeListBox;
        private System.Windows.Forms.ComboBox malzemeAra;
        private System.Windows.Forms.Button malzemeAraİptal;
        private System.Windows.Forms.Button malzemeAraButon;
        private ToolTip toolTip;
    }
}

