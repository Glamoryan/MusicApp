using MusicApp.DataAccess.Concrete.EntityFramework.Mappings;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MusicApp.DataAccess.Concrete.EntityFramework
{
    public class MusicAppContext : DbContext
    {
//#if DEBUG
//        private static List<string> ayirici = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Split('\\').SkipLast(3).ToList();
//        private static string yol = String.Join('\\', ayirici.ToList());
//        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + yol + "\\App_Data\\MusicAppDB.mdf;Integrated Security=True";
//#endif

        private static string yol = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + yol + "\\App_Data\\MusicAppDB.mdf;Integrated Security=True";        

        private static int? sarkiSayisi;
        public MusicAppContext() : base(connectionString)
        {
            SarkilariEkle();
            Database.SetInitializer<MusicAppContext>(null);
        }

        private void SarkilariEkle()
        {
            if (sarkiSayisi == null)
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    SqlCommand sarkiVarmi = new SqlCommand("SELECT COUNT(*) FROM Sarkilar", baglanti);
                    baglanti.Open();
                    sarkiSayisi = (Int32)sarkiVarmi.ExecuteScalar();
                    if (sarkiSayisi == 0)
                    {
                        string sarkiYolu = yol + "\\Sarkilar";
                        SqlCommand sarkiKomut = new SqlCommand(
                            @"
insert into Sarkilar (sanatciId,sarkiAdi,sarkiYolu,sarkiDinlenmesi,sarkiUlke,sarkiTarih) values 
(1,'Lacrimosa',@yol,0,'Avusturya',GETDATE()),
(2,'Let the Good Times Roll',@yol,0,'ABD',GETDATE()),
(3,'Toy',@yol,0,'Türkiye',GETDATE()),
(4,'La vie en rose',@yol,0,'ABD',GETDATE()),
(4,'What a wonderful world',@yol,0,'ABD',GETDATE()),
(5,'Afterglow',@yol,0,'UK',GETDATE()),
(6,'Bangir Bangir',@yol,0,'Türkiye',GETDATE()),
(7,'Dream a Little Dream of Me',@yol,0,'ABD',GETDATE()),
(8,'Kafama Göre',@yol,0,'Türkiye',GETDATE()),
(9,'Levitating',@yol,0,'UK',GETDATE()),
(3,'Öyle Kolaysa',@yol,0,'Türkiye',GETDATE()),
(10,'Ride of the Valkyries',@yol,0,'Almanya',GETDATE()),
(11,'Save Your Tears',@yol,0,'Kanada',GETDATE()),
(12,'Yolla',@yol,0,'Türkiye',GETDATE()),
(13,'The Lazy Song',@yol,0,'ABD',GETDATE()),
(11,'Blinding Lights',@yol,0,'Kanada',GETDATE()),
(14,'Counting Stars',@yol,0,'ABD',GETDATE()),
(15,'Fly Me to the Moon',@yol,0,'ABD',GETDATE()),
(16,'My Baby Just Cares for Me',@yol,0,'ABD',GETDATE()),
(17,'Strange Fruit',@yol,0,'ABD',GETDATE()),
(7,'Summer Time',@yol,0,'ABD',GETDATE()),
(18,'Take Five',@yol,0,'ABD',GETDATE()),
(19,'The Girl From Ipanema',@yol,0,'ABD',GETDATE()),
(20,'Classic 1',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 2',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 3',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 4',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 5',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 6',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 7',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 8',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 9',@yol,0,'Türkiye',GETDATE()),
(20,'Classic 10',@yol,0,'Türkiye',GETDATE())
", baglanti);
                        sarkiKomut.Parameters.AddWithValue("@yol", sarkiYolu);
                        sarkiKomut.ExecuteNonQuery();

                        SqlCommand albumDetayKomut = new SqlCommand(
                            @"
insert into AlbumDetaylari (albumId,sanatciId,sarkiId,turId) values 
(1,1,1,3),
(2,2,2,2),
(3,3,3,1),
(4,4,4,2),
(4,4,5,2),
(5,5,6,1),
(6,6,7,1),
(7,7,8,2),
(8,8,9,1),
(9,9,10,1),
(3,3,11,1),
(10,10,12,3),
(11,11,13,1),
(12,12,14,1),
(13,13,15,1),
(11,11,16,1),
(14,14,17,1),
(15,15,18,2),
(16,16,19,2),
(17,17,20,2),
(7,7,21,2),
(18,18,22,2),
(19,19,23,2),
(20,20,24,3),
(20,20,25,3),
(20,20,26,3),
(20,20,27,3),
(20,20,28,3),
(20,20,29,3),
(20,20,30,3),
(20,20,31,3),
(20,20,32,3),
(20,20,33,3)", baglanti);
                        albumDetayKomut.ExecuteNonQuery();

                        baglanti.Close();
                    }
                }
            }
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
