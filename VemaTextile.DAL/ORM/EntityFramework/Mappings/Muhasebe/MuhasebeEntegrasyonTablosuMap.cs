using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeEntegrasyonTablosuMap : EntityTypeConfiguration<MuhasebeEntegrasyonTablosu>
    {
        public MuhasebeEntegrasyonTablosuMap()
        {
            ToTable("MuhasebeEntegrasyonTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.KaynakEvrakTipi)
                .IsUnicode()
                .HasMaxLength(100);

            Property(u => u.SatirTipi)
                .IsUnicode()
                .HasMaxLength(100);


            Property(u => u.Tanim1)
               .IsUnicode()
              .HasMaxLength(100);

            Property(u => u.Tanim2)
              .IsUnicode()
             .HasMaxLength(100);

            Property(u => u.Tanim3)
              .IsUnicode()
             .HasMaxLength(100);

            Property(u => u.Tanim4)
              .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.Aciklama1)
              .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.Aciklama2)
              .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.Aciklama3)
              .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.Aciklama4)
              .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.AciklamaSQL)
              .IsUnicode()
             .HasMaxLength(1000);


            Property(u => u.TanimSQL)
              .IsUnicode()
             .HasMaxLength(1000);


            Property(u => u.FisTipi)
              .IsUnicode()
             .HasMaxLength(10);
        }


    }
}
