using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface ITurService
    {
        List<Tur> TumTurleriGetir();
        Tur TurGetir(int turId);
        Tur TurEkle(Tur tur);
        Tur TurGuncelle(Tur tur);
        void TurSil(Tur tur);
    }
}
