using System.Windows.Forms;

namespace yazlab1tarifrehberiprojesi.Views
{
    partial class Malzemeler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.artanPanel1 = new artanpanel.ArtanPanel();
            this.malzemeekle = new System.Windows.Forms.Button();
            this.artanPanel2 = new artanpanel.ArtanPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.artanPanel6 = new artanpanel.ArtanPanel();
            this.malzemeListesi = new System.Windows.Forms.DataGridView();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.artanPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.malzemeekle);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.artanPanel1.Location = new System.Drawing.Point(134, 640);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(152, 53);
            this.artanPanel1.TabIndex = 18;
            // 
            // malzemeekle
            // 
            this.malzemeekle.BackColor = System.Drawing.Color.Transparent;
            this.malzemeekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.malzemeekle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.malzemeekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.malzemeekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.malzemeekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.malzemeekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeekle.Location = new System.Drawing.Point(-10, -8);
            this.malzemeekle.Name = "malzemeekle";
            this.malzemeekle.Size = new System.Drawing.Size(174, 71);
            this.malzemeekle.TabIndex = 0;
            this.malzemeekle.Text = "Malzeme Ekle";
            this.malzemeekle.UseVisualStyleBackColor = false;
            this.malzemeekle.Click += new System.EventHandler(this.malzemeekle_Click);
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.pictureBox1);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.artanPanel2.Location = new System.Drawing.Point(3, 18);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(399, 590);
            this.artanPanel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::yazlab1tarifrehberiprojesi.Properties.Resources.malzemelist;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // artanPanel6
            // 
            this.artanPanel6.BackColor = System.Drawing.Color.White;
            this.artanPanel6.BorderRadius = 30;
            this.artanPanel6.Controls.Add(this.malzemeListesi);
            this.artanPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.artanPanel6.GradientAngle = 90F;
            this.artanPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.artanPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.artanPanel6.Location = new System.Drawing.Point(418, 18);
            this.artanPanel6.Name = "artanPanel6";
            this.artanPanel6.Padding = new System.Windows.Forms.Padding(5, 0, 4, 10);
            this.artanPanel6.Size = new System.Drawing.Size(779, 715);
            this.artanPanel6.TabIndex = 17;
            // 
            // malzemeListesi
            // 
            this.malzemeListesi.AllowUserToAddRows = false;
            this.malzemeListesi.AllowUserToDeleteRows = false;
            this.malzemeListesi.AllowUserToResizeColumns = false;
            this.malzemeListesi.AllowUserToResizeRows = false;
            this.malzemeListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.malzemeListesi.BackgroundColor = System.Drawing.Color.White;
            this.malzemeListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.malzemeListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.malzemeListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.malzemeListesi.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.malzemeListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.malzemeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.malzemeListesi.EnableHeadersVisualStyles = false;
            this.malzemeListesi.GridColor = System.Drawing.Color.LightGray;
            this.malzemeListesi.Location = new System.Drawing.Point(5, 0);
            this.malzemeListesi.MultiSelect = false;
            this.malzemeListesi.Name = "malzemeListesi";
            this.malzemeListesi.ReadOnly = true;
            this.malzemeListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.malzemeListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.malzemeListesi.RowHeadersVisible = false;
            this.malzemeListesi.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.malzemeListesi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.malzemeListesi.RowTemplate.Height = 25;
            this.malzemeListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.malzemeListesi.Size = new System.Drawing.Size(770, 705);
            this.malzemeListesi.TabIndex = 0;
            // 
            // Malzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel6);
            this.Name = "Malzemeler";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.Malzemeler_Load);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.artanPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.malzemeListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private artanpanel.ArtanPanel artanPanel6;
        private System.Windows.Forms.DataGridView malzemeListesi;
        private artanpanel.ArtanPanel artanPanel1;
        private System.Windows.Forms.Button malzemeekle;
        private artanpanel.ArtanPanel artanPanel2;
        private PictureBox pictureBox1;
    }
}
