using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class SanatciManager : ISanatciService
    {
        private ISanatciDal _sanatciDal;
        public SanatciManager(ISanatciDal sanatciDal)
        {
            _sanatciDal = sanatciDal;
        }

        public Sanatci SanatciEkle(Sanatci sanatci)
        {
            return _sanatciDal.Add(sanatci);
        }

        public Sanatci SanatciGetir(int sanatciId)
        {
            return _sanatciDal.Get(x => x.sanatciId == sanatciId);
        }

        public Sanatci SanatciGuncelle(Sanatci sanatci)
        {
            return _sanatciDal.Update(sanatci);
        }

        public void SanatciSil(Sanatci sanatci)
        {
            _sanatciDal.Delete(sanatci);
        }

        public List<Sanatci> TumSanatcilariGetir()
        {
            return _sanatciDal.GetList();
        }
    }
}
