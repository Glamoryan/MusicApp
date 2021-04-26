using MusicApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RolMap : EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            ToTable(@"Roller", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.rolAdi).HasColumnName("rolAdi");
        }
    }
}
