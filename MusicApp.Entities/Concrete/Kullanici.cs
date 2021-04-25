using MusicApp.Core.Entities;

namespace MusicApp.Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciMail { get; set; }
        public string kullaniciSifre { get; set; }
        public string ulkeAdi { get; set; }
    }
}
