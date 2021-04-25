using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class AbonelikManager : IAbonelikService
    {
        private IAbonelikDal _abonelikDal;
        public AbonelikManager(IAbonelikDal abonelikDal)
        {
            _abonelikDal = abonelikDal;
        }

        public Abonelik AbonelikEkle(Abonelik abonelik)
        {
            return _abonelikDal.Add(abonelik);
        }

        public Abonelik AbonelikGetir(int abonelikId)
        {
            return _abonelikDal.Get(x => x.abonelikId == abonelikId);
        }

        public Abonelik AbonelikGuncelle(Abonelik abonelik)
        {
            return _abonelikDal.Update(abonelik);
        }

        public void AbonelikSil(Abonelik abonelik)
        {
            _abonelikDal.Delete(abonelik);
        }

        public List<Abonelik> TumAbonelikleriGetir()
        {
            return _abonelikDal.GetList();
        }
    }
}
