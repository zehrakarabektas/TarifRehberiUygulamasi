using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazlab1proje1.Models;

namespace yazlab1tarifrehberiprojesi.Models
{
    public interface ITarifMalzemeIliskiRepository
    {
        void IliskiEkle(TarifMalzemeIliskisiModeli iliskiModeli);
        void IliskiGuncelle(TarifMalzemeIliskisiModeli iliskiModeli);
        void IliskiSil(int tarifId, int malzemeId);
        IEnumerable<(string malzeme, int malzemeId, bool stokDurumu)> GetTarifMalzemeler(int tarifId);
    }
}
