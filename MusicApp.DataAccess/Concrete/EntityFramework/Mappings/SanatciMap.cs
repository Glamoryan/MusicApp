using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SanatciMap : EntityTypeConfiguration<Sanatci>
    {
        public SanatciMap()
        {
            ToTable(@"Sanatcilar", @"dbo");
            HasKey(x => x.sanatciId);

            Property(x => x.sanatciId).HasColumnName("id");
            Property(x => x.sanatciAdi).HasColumnName("sanatciAdi");
            Property(x => x.ulkeAdi).HasColumnName("ulkeAdi");
        }
    }
}
