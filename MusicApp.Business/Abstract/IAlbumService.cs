using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IAlbumService
    {
        List<Album> TumAlbumleriGetir();
        Album AlbumGetir(int albumId);
        Album AlbumEkle(Album album);
        Album AlbumGuncelle(Album album);
        void AlbumSil(Album album);
    }
}
