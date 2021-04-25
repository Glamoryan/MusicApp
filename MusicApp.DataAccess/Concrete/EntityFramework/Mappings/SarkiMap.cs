using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SarkiMap : EntityTypeConfiguration<Sarki>
    {
        public SarkiMap()
        {
            ToTable(@"Sarkilar", @"dbo");
            HasKey(x => x.sarkiId);

            Property(x => x.sarkiId).HasColumnName("id");
            Property(x => x.sarkiAdi).HasColumnName("sarkiAdi");
            Property(x => x.sarkiYolu).HasColumnName("sarkiYolu");
        }
    }
}
