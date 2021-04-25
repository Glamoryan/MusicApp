using MusicApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TurMap : EntityTypeConfiguration<Tur>
    {
        public TurMap()
        {
            ToTable(@"Turler", @"dbo");
            HasKey(x => x.turId);

            Property(x => x.turId).HasColumnName("id");
            Property(x => x.turAdi).HasColumnName("turAdi");
        }
    }
}
