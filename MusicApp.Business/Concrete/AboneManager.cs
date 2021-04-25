using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class AboneManager : IAboneService
    {
        private IAboneDal _aboneDal;

        public AboneManager(IAboneDal aboneDal)
        {
            _aboneDal = aboneDal;
        }

        public Abone AboneEkle(Abone abone)
        {
            return _aboneDal.Add(abone);
        }

        public Abone AboneGuncelle(Abone abone)
        {
            return _aboneDal.Update(abone);
        }

        public void AboneSil(Abone abone)
        {
            _aboneDal.Delete(abone);
        }

        public Abone AboneyiGetir(int kullaniciId)
        {
            return _aboneDal.Get(x => x.kullaniciId == kullaniciId);
        }

        public List<Abone> TumAboneleriGetir()
        {
            return _aboneDal.GetList();
        }

        public List<Abone> TureGoreGetir(int aboneTuruId)
        {
            return _aboneDal.GetList(x => x.abonelikId == aboneTuruId);
        }
    }
}
