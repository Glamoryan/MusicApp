using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class TurManager : ITurService
    {
        private ITurDal _turDal;
        public TurManager(ITurDal turDal)
        {
            _turDal = turDal;
        }
        public List<Tur> TumTurleriGetir()
        {
            return _turDal.GetList();
        }

        public Tur TurEkle(Tur tur)
        {
            return _turDal.Add(tur);
        }

        public Tur TurGetir(int turId)
        {
            return _turDal.Get(x => x.turId == turId);
        }

        public Tur TurGuncelle(Tur tur)
        {
            return _turDal.Update(tur);
        }

        public void TurSil(Tur tur)
        {
            _turDal.Delete(tur);
        }
    }
}
