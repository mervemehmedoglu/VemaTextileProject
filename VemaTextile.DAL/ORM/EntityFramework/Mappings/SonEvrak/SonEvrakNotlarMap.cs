using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.SonEvrak
{
    public class SonEvrakNotlarMap : EntityTypeConfiguration<SonEvrakNotlar>
    {
        public SonEvrakNotlarMap()
        {
            ToTable("SonEvrakNotlarTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.Kaydeden)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.KaynakEvrakTipi)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.EvrakNo)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.Seri)
              .IsUnicode()
             .HasMaxLength(4);
        }


    }
}
