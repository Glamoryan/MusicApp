using MusicApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AlbumDetayMap : EntityTypeConfiguration<AlbumDetay>
    {
        public AlbumDetayMap()
        {
            ToTable(@"AlbumDetaylari", @"dbo");
            HasKey(x => x.albumDetayId);

            Property(x => x.albumDetayId).HasColumnName("id");
            Property(x => x.albumId).HasColumnName("albumId");
            Property(x => x.sanatciId).HasColumnName("sanatciId");
            Property(x => x.sarkiId).HasColumnName("sarkiId");
            Property(x => x.turId).HasColumnName("turId");
        }
    }
}
