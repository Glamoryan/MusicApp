using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> TumKullanicilariGetir();
        Kullanici KullaniciLogin(string kullaniciAdi, string sifre);
        Kullanici KullaniciGetir(int kullaniciId);
        Kullanici KullaniciEkle(Kullanici kullanici);
        Kullanici KullaniciGuncelle(Kullanici kullanici);
        void KullaniciSil(Kullanici kullanici);
    }
}
