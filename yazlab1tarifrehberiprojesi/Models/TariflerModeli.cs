using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace yazlab1proje1.Models
{
    public class TariflerModeli
    {
        private int tarifID;
        private string tarifAdi;
        private string kategoriAdi;
        private int hazirlamaSuresi;
        private string talimatlar;
        private string tarifResmi;
        private bool tarifStokDurumu;
        private float tarifMaliyeti;
        private float stokMaliyeti;
        private float eslesmeYuzdesi;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Tarif ID")]
        public int TarifID { get { return tarifID; } set { this.tarifID=value; } }

        [DisplayName("Tarif Adı")]
        [Required(ErrorMessage = "Tarif adı girilmesi zorunludur.")]
        public string TarifAdi { get { return tarifAdi; } set { this.tarifAdi=value; } }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Tarifin kategorisinin girilmesi zorunludur.")]
        public string KategoriAdi { get { return kategoriAdi; } set { this.kategoriAdi=value; } }

        [DisplayName("Hazırlama Süresi")]
        [Required(ErrorMessage = "Tarifin hazırlama süresinin girilmesi zorunludur.")]
        public int HazirlamaSüresi { get { return hazirlamaSuresi; } set { this.hazirlamaSuresi=value; } }

        [DisplayName("Talimatlar")]
        [Required(ErrorMessage = "Tarifin yapılışının girilmesi zorunludur.")]
        public string Talimatlar { get { return talimatlar; } set { this.talimatlar=value; } }


        [DisplayName("Tarif Resmi")]
        public string TarifResmi { get { return tarifResmi; } set { this.tarifResmi=value; } }

        public bool TarifStokDurumu { get { return tarifStokDurumu; } set { this.tarifStokDurumu=value; } }
        public float TarifMaliyeti { get { return tarifMaliyeti; } set { tarifMaliyeti=value; } }

        public float StokMaliyeti { get { return stokMaliyeti; } set { stokMaliyeti=value; } }

        public float EslesmeYuzdesi { get { return eslesmeYuzdesi; } set { eslesmeYuzdesi=value; } }
    }
}
