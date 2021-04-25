using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KullaniciTakipMap : EntityTypeConfiguration<KullaniciTakip>
    {
        public KullaniciTakipMap()
        {
            ToTable(@"KullaniciTakipleri", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.kullaniciId).HasColumnName("kullaniciId");
            Property(x => x.takipciId).HasColumnName("takipciId");
        }
    }
}
