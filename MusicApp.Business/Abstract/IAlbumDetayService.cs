using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IAlbumDetayService
    {
        List<AlbumDetay> TumAlbumDetaylariGetir();
        AlbumDetay AlbumDetayiGetir(int albumId);
        AlbumDetay SanatciAlbumuGetir(int sanatciId);
        AlbumDetay SarkiAlbumuGetir(int sarkiId);
        AlbumDetay TurAlbumuGetir(int turId);
        AlbumDetay AlbumDetayEkle(AlbumDetay albumDetay);
        AlbumDetay AlbumDetayGuncelle(AlbumDetay albumDetay);
        void AlbumDetaySil(AlbumDetay albumDetay);
    }
}
