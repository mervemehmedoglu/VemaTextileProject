using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Islemler
{
    public class SilinenKayitlarMap : EntityTypeConfiguration<SilinenKayitlar>
    {
        public SilinenKayitlarMap()
        {
            ToTable("SilinenKayitlarTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.KaynakEvrakTipi)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.Kaydeden)
               .IsUnicode()
              .HasMaxLength(20);


        }


    }
}
