using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazlab1proje1.Models;
using yazlab1tarifrehberiprojesi.Database;

namespace yazlab1tarifrehberiprojesi.Models
{
    public interface ITariflerRepository
    {
        int TarifEkle(TariflerModeli tarifModeli);
        void TarifGuncelle(TariflerModeli tarifModeli, int tarifId);
        void TarifSil(int tarifId);
        IEnumerable<TariflerModeli> GetAll();
        IEnumerable<TariflerModeli> GetTariflerListesi(string kategori, string malzemeSayisi,string maliyetAraligi, List<int> secilenMalzemeIdleri,int sirala, string arama);
        TariflerModeli GetTarifDetay(int tarifId);
        List<string> TarifKategorileri();
    }
}
