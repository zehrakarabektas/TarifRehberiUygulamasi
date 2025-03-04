using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab1tarifrehberiprojesi
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None; // Pencere kenarlıklarını kaldırır
            this.Width = 300; // Genişlik
            this.Height = 100; // Yükseklik
            this.BackColor = System.Drawing.Color.White; // Arkaplan rengi

            // Yükleniyor mesajı için Label
            Label loadingLabel = new Label();
            loadingLabel.Text = "Yükleniyor, lütfen bekleyin...";
            loadingLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            loadingLabel.AutoSize = true;
            loadingLabel.Location = new System.Drawing.Point((this.Width - loadingLabel.Width) / 2, 30);
            loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.Controls.Add(loadingLabel);

            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Width = 250;
            progressBar.Location = new System.Drawing.Point((this.Width - progressBar.Width) / 2, 60);

            this.Controls.Add(progressBar);
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }
    }
}
