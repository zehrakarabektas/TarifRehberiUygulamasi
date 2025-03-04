using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab1proje1.Models
{
    public class MalzemelerModeli
    {
        private int malzemeId;
        private string malzemeAdi;
        private string toplamMiktar;
        private string malzemeBirim;
        private float birimFiyat;
        private bool malzemeDurum;

        [Key]
        [DisplayName("Malzeme ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MalzemeId { get { return malzemeId; } set { this.malzemeId=value; } }

        [DisplayName("Malzeme Adı")]
        [Required(ErrorMessage = "Malzeme adı girilmesi zorunludur.")]
        public string MalzemeAdi { get { return malzemeAdi; } set { malzemeAdi=value; } }

        [DisplayName("Stoktaki Toplam Miktar")]
        [Required(ErrorMessage = "Stoktaki toplam miktarı girilmesi zorunludur.")]
        public string ToplamMiktar { get { return toplamMiktar; } set { this.toplamMiktar=value; } }

        [DisplayName("Malzeme Birim")]
        [Required(ErrorMessage = "Malzemenin biriminin girilmesi zorunludur.")]
        public string MalzemeBirim { get { return malzemeBirim; } set { this.malzemeBirim=value; } }

        [DisplayName("Birim Fiyat")]
        [Required(ErrorMessage = "Malzeme birim fiyatının girilmesi zorunludur.")]
        public float BirimFiyat { get { return birimFiyat; } set { birimFiyat=value; } }

        public bool MalzemeDurum { get { return malzemeDurum; } set { malzemeDurum=value; } }
    }
}
