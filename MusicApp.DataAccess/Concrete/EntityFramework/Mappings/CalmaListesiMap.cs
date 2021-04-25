using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CalmaListesiMap : EntityTypeConfiguration<CalmaListesi>
    {
        public CalmaListesiMap()
        {
            ToTable(@"CalmaListeleri", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.kullaniciId).HasColumnName("kullaniciId");
            Property(x => x.sarkiId).HasColumnName("sarkiId");
            Property(x => x.turId).HasColumnName("turId");
        }
    }
}
