using MusicApp.Core.Entities;

namespace MusicApp.Entities.Concrete
{
    public class Sarki : IEntity
    {
        public int sarkiId { get; set; }
        public string sarkiAdi { get; set; }
        public string sarkiYolu { get; set; } //Şarkı dosyasının nerede olduğu
    }
}
