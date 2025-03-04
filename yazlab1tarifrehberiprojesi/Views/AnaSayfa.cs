using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab1tarifrehberiprojesi.Views
{
    public partial class AnaSayfa : UserControl
    {
        public event EventHandler<string> CorbalaraBasildi, SalatalaraBasildi, AnaYemeklereBasildi, TatlilaraBasildi, AtistirmaliklaraBasildi,YenikategorilereBasildi;
        private string kategori;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kategori="Çorbalar";
            CorbalaraBasildi?.Invoke(this,kategori);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kategori=null;
            YenikategorilereBasildi?.Invoke(this,kategori);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kategori="Salatalar";
            SalatalaraBasildi?.Invoke(this, kategori);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kategori="Ana Yemek";
            AnaYemeklereBasildi.Invoke(this,kategori);
            
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            kategori="Atıştırmalıklar";
            AtistirmaliklaraBasildi.Invoke(this, kategori);

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            kategori="Tatlılar";
            TatlilaraBasildi.Invoke(this, kategori);
           
        }

       

    }
}
