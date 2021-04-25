using MusicApp.Core.Entities;
using System;

namespace MusicApp.Entities.Concrete
{
    public class Album : IEntity
    {
        public int albumId { get; set; }
        public string albumAdi { get; set; }
        public DateTime albumTarih { get; set; }
    }
}
