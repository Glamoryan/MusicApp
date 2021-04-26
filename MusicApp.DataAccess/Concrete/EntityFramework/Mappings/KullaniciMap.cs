using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            ToTable(@"Kullanicilar", @"dbo");
            HasKey(x => x.kullaniciId);

            Property(x => x.kullaniciId).HasColumnName("id");
            Property(x => x.rolId).HasColumnName("rolId");
            Property(x => x.kullaniciAdi).HasColumnName("kullaniciAdi");
            Property(x => x.kullaniciMail).HasColumnName("kullaniciMail");
            Property(x => x.kullaniciSifre).HasColumnName("kullaniciSifre");
            Property(x => x.ulkeAdi).HasColumnName("ulkeAdi");
        }
    }
}
