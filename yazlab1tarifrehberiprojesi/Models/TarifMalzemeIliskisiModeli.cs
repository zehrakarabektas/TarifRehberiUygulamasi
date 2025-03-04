using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab1proje1.Models
{
    public class TarifMalzemeIliskisiModeli
    {
        private int tarifID;
        private int malzemeID;
        private float malzemeMiktar;

        [ForeignKey("TariflerModeli")]
        [DisplayName ("Tarif ID" )]
        public int TarifID
        {
            get { return tarifID; }
            set { this.tarifID = value; }
        }

        [ForeignKey("MalzemelerModeli")]
        [DisplayName("Malzeme ID")]
        public int MalzemeID
        {
            get { return malzemeID; }
            set { this.malzemeID = value; }
        }

        [Required(ErrorMessage = "Malzeme miktarının girilmesi zorunludur.")]
        [DisplayName("Malzeme Miktarı")]
        public float MalzemeMiktar
        {
            get { return malzemeMiktar; }
            set { this.malzemeMiktar = value; }
        }

        public virtual TariflerModeli TariflerModeli { get; set; }
        public virtual MalzemelerModeli MalzemelerModeli { get; set; }
    }
}

