using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class SarkiManager : ISarkiService
    {
        private ISarkiDal _sarkiDal;
        public SarkiManager(ISarkiDal sarkiDal)
        {
            _sarkiDal = sarkiDal;
        }
        public List<Sarki> SanatciSarkilariniGetir(int sanatciId)
        {
            return _sarkiDal.GetList(x => x.sanatciId == sanatciId);
        }

        public Sarki SarkiEkle(Sarki sarki)
        {
            return _sarkiDal.Add(sarki);
        }

        public Sarki SarkiGetir(int sarkiId)
        {
            return _sarkiDal.Get(x => x.sarkiId == sarkiId);
        }

        public Sarki SarkiGuncelle(Sarki sarki)
        {
            return _sarkiDal.Update(sarki);
        }

        public void SarkiSil(Sarki sarki)
        {
            _sarkiDal.Delete(sarki);
        }

        public List<Sarki> TumSarkilariGetir()
        {
            return _sarkiDal.GetList();
        }
    }
}
