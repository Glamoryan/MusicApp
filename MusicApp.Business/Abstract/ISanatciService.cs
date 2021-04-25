using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface ISanatciService
    {
        List<Sanatci> TumSanatcilariGetir();
        Sanatci SanatciGetir(int sanatciId);
        Sanatci SanatciEkle(Sanatci sanatci);
        Sanatci SanatciGuncelle(Sanatci sanatci);
        void SanatciSil(Sanatci sanatci);
    }
}
