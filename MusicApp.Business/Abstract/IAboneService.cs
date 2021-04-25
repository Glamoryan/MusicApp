using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IAboneService
    {
        List<Abone> TumAboneleriGetir();
        Abone AboneyiGetir(int kullaniciId);
        Abone AboneEkle(Abone abone);
        Abone AboneGuncelle(Abone abone);
        void AboneSil(Abone abone);
        List<Abone> TureGoreGetir(int aboneTuruId);
    }
}
