using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IAbonelikService
    {
        List<Abonelik> TumAbonelikleriGetir();
        Abonelik AbonelikGetir(int abonelikId);
        Abonelik AbonelikEkle(Abonelik abonelik);
        Abonelik AbonelikGuncelle(Abonelik abonelik);
        void AbonelikSil(Abonelik abonelik);
    }
}
