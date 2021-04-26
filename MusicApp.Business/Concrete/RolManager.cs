using MusicApp.Business.Abstract;
using MusicApp.DataAccess.Abstract;
using MusicApp.Entities.Concrete;
using System.Collections.Generic;

namespace MusicApp.Business.Concrete
{
    public class RolManager : IRolService
    {
        private IRolDal _rolDal;
        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }
        public Rol RolEkle(Rol rol)
        {
            return _rolDal.Add(rol);
        }

        public Rol RolGetir(int rolId)
        {
            return _rolDal.Get(x => x.id == rolId);
        }

        public Rol RolGuncelle(Rol rol)
        {
            return _rolDal.Update(rol);
        }

        public void RolSil(Rol rol)
        {
            _rolDal.Delete(rol);
        }

        public List<Rol> TumRolleriGetir()
        {
            return _rolDal.GetList();
        }
    }
}
