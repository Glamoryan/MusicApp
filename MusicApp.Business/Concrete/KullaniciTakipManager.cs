using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class KullaniciTakipManager : IKullaniciTakipService
    {
        private IKullaniciTakipDal _kullaniciTakipDal;
        public KullaniciTakipManager(IKullaniciTakipDal kullaniciTakipDal)
        {
            _kullaniciTakipDal = kullaniciTakipDal;
        }
        public List<KullaniciTakip> KullanicininTakipcileriniGetir(int kullaniciId)
        {
            return _kullaniciTakipDal.GetList(x => x.kullaniciId == kullaniciId);
        }

        public KullaniciTakip KullaniciTakipEkle(KullaniciTakip kullaniciTakip)
        {
            return _kullaniciTakipDal.Add(kullaniciTakip);
        }

        public KullaniciTakip KullaniciTakipGuncelle(KullaniciTakip kullaniciTakip)
        {
            return _kullaniciTakipDal.Update(kullaniciTakip);
        }

        public void KullaniciTakipSil(KullaniciTakip kullaniciTakip)
        {
            _kullaniciTakipDal.Delete(kullaniciTakip);
        }

        public List<KullaniciTakip> TakipEttikleriniGetir(int suankiKullaniciId)
        {
            return _kullaniciTakipDal.GetList(x => x.takipciId == suankiKullaniciId);
        }

        public List<KullaniciTakip> TumKullaniciTakipleriniGetir()
        {
            return _kullaniciTakipDal.GetList();
        }
    }
}
