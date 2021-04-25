using MusicApp.Core.Entities;

namespace MusicApp.Entities.Concrete
{
    public class Sanatci : IEntity
    {
        public int sanatciId { get; set; }
        public string sanatciAdi { get; set; }
        public string ulkeAdi { get; set; }
    }
}
