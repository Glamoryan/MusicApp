using MusicApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Entities.Concrete
{
    public class KullaniciTakip : IEntity
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int takipciId { get; set; } //Bu kullanıcıyı takip eden kullanıcı id'si
    }
}
