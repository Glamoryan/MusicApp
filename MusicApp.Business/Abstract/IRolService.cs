using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Abstract
{
    public interface IRolService
    {
        List<Rol> TumRolleriGetir();
        Rol RolGetir(int rolId);
        Rol RolEkle(Rol rol);
        Rol RolGuncelle(Rol rol);
        void RolSil(Rol rol);
    }
}
