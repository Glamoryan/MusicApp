using MusicApp.Core.DataAccess.EntityFramework;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;

namespace MusicApp.DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciTakipDal:EfEntityRepositoryBase<KullaniciTakip,MusicAppContext>,IKullaniciTakipDal
    {
    }
}
