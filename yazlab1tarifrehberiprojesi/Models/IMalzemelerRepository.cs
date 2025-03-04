using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yazlab1proje1.Models;

namespace yazlab1tarifrehberiprojesi.Models
{
    public interface IMalzemelerRepository
    {
        IEnumerable<MalzemelerModeli> GetMalzemeler();
        void MalzemeEkle(MalzemelerModeli malzemeModeli);
        void MalzemeGuncelle(MalzemelerModeli malzemeModeli);
        void MalzemeSil(int malzemeId);
        string MalzemeBirimiGetir(int malzemeId);
        void StokGuncelle(int malzemeId, string toplamMiktar);
        int GetMalzemeId(string malzemeAdi);
        MalzemelerModeli GetMalzemeDetay(int malzemeId);
        List<string> MalzemeBirimleri();
    }
}
