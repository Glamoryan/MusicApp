using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class AlbumDetayManager : IAlbumDetayService
    {
        private IAlbumDetayDal _albumDetayDal;
        public AlbumDetayManager(IAlbumDetayDal albumDetayDal)
        {
            _albumDetayDal = albumDetayDal;
        }

        public AlbumDetay AlbumDetayEkle(AlbumDetay albumDetay)
        {
            return _albumDetayDal.Add(albumDetay);
        }

        public AlbumDetay AlbumDetayGuncelle(AlbumDetay albumDetay)
        {
            return _albumDetayDal.Update(albumDetay);
        }

        public AlbumDetay AlbumDetayiGetir(int albumId)
        {
            return _albumDetayDal.Get(x => x.albumId == albumId);
        }

        public void AlbumDetaySil(AlbumDetay albumDetay)
        {
            _albumDetayDal.Delete(albumDetay);
        }

        public AlbumDetay SanatciAlbumuGetir(int sanatciId)
        {
            return _albumDetayDal.Get(x => x.sanatciId == sanatciId);
        }

        public AlbumDetay SarkiAlbumuGetir(int sarkiId)
        {
            return _albumDetayDal.Get(x => x.sarkiId == sarkiId);
        }

        public List<AlbumDetay> TumAlbumDetaylariGetir()
        {
            return _albumDetayDal.GetList();
        }

        public AlbumDetay TurAlbumuGetir(int turId)
        {
            return _albumDetayDal.Get(x => x.turId == turId);
        }
    }
}
