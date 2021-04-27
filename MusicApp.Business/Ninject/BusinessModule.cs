using MusicApp.Business.Abstract;
using MusicApp.Business.Concrete;
using MusicApp.DataAccess.Abstract;
using MusicApp.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MusicApp.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //Business injections
            Bind<IAbonelikService>().To<AbonelikManager>().InSingletonScope();
            Bind<IAboneService>().To<AboneManager>().InSingletonScope();
            Bind<IAlbumDetayService>().To<AlbumDetayManager>().InSingletonScope();
            Bind<IAlbumService>().To<AlbumManager>().InSingletonScope();
            Bind<ICalmaListesiService>().To<CalmaListesiManager>().InSingletonScope();
            Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();
            Bind<IKullaniciTakipService>().To<KullaniciTakipManager>().InSingletonScope();
            Bind<IRolService>().To<RolManager>().InSingletonScope();
            Bind<ISanatciService>().To<SanatciManager>().InSingletonScope();
            Bind<ISarkiService>().To<SarkiManager>().InSingletonScope();
            Bind<ITurService>().To<TurManager>().InSingletonScope();

            //Data Access injections
            Bind<IAboneDal>().To<EfAboneDal>().InSingletonScope();
            Bind<IAbonelikDal>().To<EfAbonelikDal>().InSingletonScope();
            Bind<IAlbumDal>().To<EfAlbumDal>().InSingletonScope();
            Bind<IAlbumDetayDal>().To<EfAlbumDetayDal>().InSingletonScope();
            Bind<ICalmaListesiDal>().To<EfCalmaListesiDal>().InSingletonScope();
            Bind<IKullaniciDal>().To<EfKullaniciDal>().InSingletonScope();
            Bind<IKullaniciTakipDal>().To<EfKullaniciTakipDal>().InSingletonScope();
            Bind<IRolDal>().To<EfRolDal>().InSingletonScope();
            Bind<ISanatciDal>().To<EfSanatciDal>().InSingletonScope();
            Bind<ISarkiDal>().To<EfSarkiDal>().InSingletonScope();
            Bind<ITurDal>().To<EfTurDal>().InSingletonScope();
        }
    }
}
