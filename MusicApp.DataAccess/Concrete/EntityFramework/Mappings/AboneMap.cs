using MusicApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AboneMap : EntityTypeConfiguration<Abone>
    {
        public AboneMap()
        {
            ToTable(@"Aboneler", @"dbo");
            HasKey(x => x.aboneId);

            Property(x => x.aboneId).HasColumnName("id");
            Property(x => x.kullaniciId).HasColumnName("kullaniciId");
            Property(x => x.abonelikId).HasColumnName("abonelikTuru");
            Property(x => x.odendi).HasColumnName("odendi");
        }
    }
}
