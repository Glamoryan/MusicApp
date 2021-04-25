using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Business.Abstract
{
    public interface ISarkiService
    {
        List<Sarki> TumSarkilariGetir();
        Sarki SarkiGetir(int sarkiId);
        List<Sarki> SanatciSarkilariniGetir(int sanatciId);
        Sarki SarkiEkle(Sarki sarki);
        Sarki SarkiGuncelle(Sarki sarki);
        void SarkiSil(Sarki sarki);
    }
}
