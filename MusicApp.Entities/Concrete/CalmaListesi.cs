using MusicApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Entities.Concrete
{
    public class CalmaListesi : IEntity
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int sarkiId { get; set; }
        public int turId { get; set; }

        public Dictionary<int,byte> sarkiTurListesi { get; set; } //Şarkıları ve türünü tutan liste
    }
}
