using MusicApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Entities.Concrete
{
    public class AlbumDetay : IEntity
    {
        public int albumDetayId { get; set; }
        public int albumId { get; set; }
        public int sanatciId { get; set; }
        public int sarkiId { get; set; }
        public int turId { get; set; }

        public List<int> sarkiListesi { get; set; } //Şarkıların id'sini tutan liste
    }
}
