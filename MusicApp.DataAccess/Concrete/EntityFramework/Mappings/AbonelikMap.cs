using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AbonelikMap : EntityTypeConfiguration<Abonelik>
    {
        public AbonelikMap()
        {
            ToTable(@"Abonelikler",@"dbo");
            HasKey(x => x.abonelikId);

            Property(x => x.abonelikId).HasColumnName("id");
            Property(x => x.abonelikAdi).HasColumnName("abonelikTuru");
        }
    }
}
