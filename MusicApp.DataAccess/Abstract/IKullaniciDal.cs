﻿using MusicApp.Core.DataAccess;
using MusicApp.Entities.Concrete;

namespace MusicApp.DataAccess.Abstract
{
    public interface IKullaniciDal : IEntityRepository<Kullanici>
    {
    }
}
