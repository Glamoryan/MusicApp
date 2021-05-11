using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class CalmaListesiManager : ICalmaListesiService
    {
        private ICalmaListesiDal _calmaListesiDal;
        public CalmaListesiManager(ICalmaListesiDal calmaListesiDal)
        {
            _calmaListesiDal = calmaListesiDal;
        }

        public CalmaListesi CalmaListesiEkle(CalmaListesi calmaListesi)
        {
            return _calmaListesiDal.Add(calmaListesi);
        }

        public CalmaListesi CalmaListesiGetir(int calmaListesiId)
        {
            return _calmaListesiDal.Get(x => x.id == calmaListesiId);
        }

        public CalmaListesi CalmaListesiGuncelle(CalmaListesi calmaListesi)
        {
            return _calmaListesiDal.Update(calmaListesi);
        }

        public void CalmaListesiSil(CalmaListesi calmaListesi)
        {
            _calmaListesiDal.Delete(calmaListesi);
        }

        public List<CalmaListesi> KullaniciCalmaListeleriniGetir(int kullaniciId)
        {
            return _calmaListesiDal.GetList(x => x.kullaniciId == kullaniciId);
        }

        public List<CalmaListesi> SarkiCalmaListeleriGetir(int sarkiId)
        {
            return _calmaListesiDal.GetList(x => x.sarkiId == sarkiId);
        }

        public List<CalmaListesi> TumCalmaListeleriniGetir()
        {
            return _calmaListesiDal.GetList();
        }
    }
}
