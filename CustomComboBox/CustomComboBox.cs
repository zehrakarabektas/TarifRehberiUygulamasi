using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomComboBox
{
    public class CustomComboBox : ComboBox
    {
        private CheckedListBox checkedListBox;

        public CustomComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed; // Çizim modunu ayarlıyoruz
            this.checkedListBox = new CheckedListBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                CheckOnClick = true
            };
            this.checkedListBox.ItemCheck += CheckedListBox_ItemCheck;
            this.DropDownClosed += CustomComboBox_DropDownClosed;
            this.DropDownStyle = ComboBoxStyle.DropDown; // Kullanıcı metin girişi yapabilsin
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            this.checkedListBox.Items.Clear();
            foreach (var item in this.Items)
            {
                this.checkedListBox.Items.Add(item, false);
            }
            this.checkedListBox.Height = 200; // Yükseklik ayarı
            this.checkedListBox.Width = this.Width; // Genişlik ayarı

            // ListBox'u konumlandır
            this.checkedListBox.Location = new Point(this.Left, this.Bottom);
            this.Parent.Controls.Add(this.checkedListBox);
            this.checkedListBox.BringToFront();
            this.checkedListBox.Visible = true;
        }

        private void CustomComboBox_DropDownClosed(object sender, EventArgs e)
        {
            this.checkedListBox.Visible = false;
            this.Items.Clear();

            foreach (var item in checkedListBox.CheckedItems)
            {
                this.Items.Add(item);
            }

            // Seçilen öğeleri göster
            this.Text = string.Join(", ", this.Items.Cast<string>());
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Seçilen öğenin gösterimini güncelle
            if (e.NewValue == CheckState.Checked)
            {
                if (!this.Items.Contains(checkedListBox.Items[e.Index]))
                {
                    this.Items.Add(checkedListBox.Items[e.Index]);
                }
            }
            else
            {
                if (this.Items.Contains(checkedListBox.Items[e.Index]))
                {
                    this.Items.Remove(checkedListBox.Items[e.Index]);
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Çizim olayı burada işlenir
            if (e.Index < 0) return; // Geçersiz indeks kontrolü

            e.DrawBackground();
            // Seçili öğeleri göster
            string text = string.Join(", ", this.Items.Cast<string>());
            e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.checkedListBox?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
