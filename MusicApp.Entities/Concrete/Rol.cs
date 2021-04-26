using MusicApp.Core.Entities;

namespace MusicApp.Entities.Concrete
{
    public class Rol : IEntity
    {
        public int id { get; set; }
        public string rolAdi { get; set; }
    }
}
