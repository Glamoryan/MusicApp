using MusicApp.DataAccess.Concrete.EntityFramework.Mappings;
using MusicApp.Entities.Concrete;
using System;
using System.Data.Entity;
using System.IO;
using System.Reflection;

namespace MusicApp.DataAccess.Concrete.EntityFramework
{
    public class MusicAppContext:DbContext
    {
        public MusicAppContext()
        {
            Database.SetInitializer<MusicAppContext>(null); //Veritabanı bulunamazsa yeni veritabanı oluşturmasını engelliyoruz
            //AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\App_Data");
        }

        public DbSet<Abone> Aboneler { get; set; }
        public DbSet<Abonelik> Abonelikler { get; set; }
        public DbSet<Album> Albumler { get; set; }
        public DbSet<AlbumDetay> AlbumDetaylari { get; set; }
        public DbSet<CalmaListesi> CalmaListeleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciTakip> KullaniciTakipleri { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }
        public DbSet<Sarki> Sarkilar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Rol> Roller { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AboneMap());
            modelBuilder.Configurations.Add(new AbonelikMap());
            modelBuilder.Configurations.Add(new AlbumMap());
            modelBuilder.Configurations.Add(new AlbumDetayMap());
            modelBuilder.Configurations.Add(new CalmaListesiMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciTakipMap());
            modelBuilder.Configurations.Add(new SanatciMap());
            modelBuilder.Configurations.Add(new SarkiMap());
            modelBuilder.Configurations.Add(new TurMap());
            modelBuilder.Configurations.Add(new RolMap());

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("date"));            
        }
    }
}
