using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface ICalmaListesiService
    {
        List<CalmaListesi> TumCalmaListeleriniGetir();
        CalmaListesi CalmaListesiGetir(int calmaListesiId);
        List<CalmaListesi> KullaniciCalmaListeleriniGetir(int kullaniciId);
        CalmaListesi CalmaListesiEkle(CalmaListesi calmaListesi);
        CalmaListesi CalmaListesiGuncelle(CalmaListesi calmaListesi);
        void CalmaListesiSil(CalmaListesi calmaListesi);
    }
}
