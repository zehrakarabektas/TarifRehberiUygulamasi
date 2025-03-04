using System.Windows.Forms;

namespace yazlab1tarifrehberiprojesi.Views
{
    partial class Tarifler
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
            this.artanPanel6 = new artanpanel.ArtanPanel();
            this.tariflerListesi = new System.Windows.Forms.DataGridView();
            this.artanPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariflerListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPanel6
            // 
            this.artanPanel6.BackColor = System.Drawing.Color.White;
            this.artanPanel6.BorderRadius = 30;
            this.artanPanel6.Controls.Add(this.tariflerListesi);
            this.artanPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.artanPanel6.GradientAngle = 90F;
            this.artanPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            this.artanPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.artanPanel6.Location = new System.Drawing.Point(3, 18);
            this.artanPanel6.Name = "artanPanel6";
            this.artanPanel6.Padding = new System.Windows.Forms.Padding(5, 0, 4, 10);
            this.artanPanel6.Size = new System.Drawing.Size(1194, 715);
            this.artanPanel6.TabIndex = 18;
            // 
            // tariflerListesi
            // 
            this.tariflerListesi.AllowUserToAddRows = false;
            this.tariflerListesi.AllowUserToDeleteRows = false;
            this.tariflerListesi.AllowUserToResizeColumns = false;
            this.tariflerListesi.AllowUserToResizeRows = false;
            this.tariflerListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tariflerListesi.BackgroundColor = System.Drawing.Color.White;
            this.tariflerListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tariflerListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tariflerListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tariflerListesi.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tariflerListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.tariflerListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tariflerListesi.EnableHeadersVisualStyles = false;
            this.tariflerListesi.GridColor = System.Drawing.Color.LightGray;
            this.tariflerListesi.Location = new System.Drawing.Point(5, 0);
            this.tariflerListesi.MultiSelect = false;
            this.tariflerListesi.Name = "tariflerListesi";
            this.tariflerListesi.ReadOnly = true;
            this.tariflerListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(129)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tariflerListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tariflerListesi.RowHeadersVisible = false;
            this.tariflerListesi.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tariflerListesi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tariflerListesi.RowTemplate.Height = 25;
            this.tariflerListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tariflerListesi.Size = new System.Drawing.Size(1185, 705);
            this.tariflerListesi.TabIndex = 0;
            // 
            // Tarifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artanPanel6);
            this.Name = "Tarifler";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.Tarifler_Load);
            this.artanPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tariflerListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private artanpanel.ArtanPanel artanPanel6;
        private System.Windows.Forms.DataGridView tariflerListesi;
    }
}
