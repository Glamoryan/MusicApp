﻿using MusicApp.Core.DataAccess.EntityFramework;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;

namespace MusicApp.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciDal:EfEntityRepositoryBase<Kullanici,MusicAppContext>,IKullaniciDal
    {
    }
}
