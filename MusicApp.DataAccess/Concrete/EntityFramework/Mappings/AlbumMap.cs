using MusicApp.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace MusicApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            ToTable(@"Albumler", @"dbo");
            HasKey(x => x.albumId);

            Property(x => x.albumId).HasColumnName("id");
            Property(x => x.albumAdi).HasColumnName("albumAdi");
            Property(x => x.albumTarih).HasColumnName("albumTarih");
        }
    }
}
