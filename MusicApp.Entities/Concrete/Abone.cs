using MusicApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Entities.Concrete
{
    public class Abone : IEntity
    {
        public int aboneId { get; set; }
        public int kullaniciId { get; set; }
        public int abonelikId { get; set; }
        public bool odendi { get; set; }
    }
}
