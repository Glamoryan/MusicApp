using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public Kullanici KullaniciEkle(Kullanici kullanici)
        {
            return _kullaniciDal.Add(kullanici);
        }

        public Kullanici KullaniciGetir(int kullaniciId)
        {
            return _kullaniciDal.Get(x => x.kullaniciId == kullaniciId);
        }

        public Kullanici KullaniciGuncelle(Kullanici kullanici)
        {
            return _kullaniciDal.Update(kullanici);
        }

        public void KullaniciSil(Kullanici kullanici)
        {
            _kullaniciDal.Delete(kullanici);
        }

        public List<Kullanici> TumKullanicilariGetir()
        {
            return _kullaniciDal.GetList();
        }
    }
}
