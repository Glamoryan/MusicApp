using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Business.Abstract
{
    public interface IKullaniciTakipService
    {
        List<KullaniciTakip> TumKullaniciTakipleriniGetir();
        List<KullaniciTakip> KullanicininTakipcileriniGetir(int kullaniciId);
        List<KullaniciTakip> TakipEttikleriniGetir(int suankiKullaniciId);
        KullaniciTakip KullaniciTakipEkle(KullaniciTakip kullaniciTakip);
        KullaniciTakip KullaniciTakipGuncelle(KullaniciTakip kullaniciTakip);
        void KullaniciTakipSil(KullaniciTakip kullaniciTakip);        
    }
}
