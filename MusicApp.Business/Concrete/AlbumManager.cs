using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class AlbumManager : IAlbumService
    {
        private IAlbumDal _albumDal;
        public AlbumManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }

        public Album AlbumEkle(Album album)
        {
            return _albumDal.Add(album);
        }

        public Album AlbumGetir(int albumId)
        {
            return _albumDal.Get(x => x.albumId == albumId);
        }

        public Album AlbumGuncelle(Album album)
        {
            return _albumDal.Update(album);
        }

        public void AlbumSil(Album album)
        {
            _albumDal.Delete(album);
        }

        public List<Album> TumAlbumleriGetir()
        {
            return _albumDal.GetList();
        }
    }
}
