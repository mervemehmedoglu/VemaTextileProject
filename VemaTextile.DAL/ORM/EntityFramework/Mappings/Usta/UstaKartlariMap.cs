using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Usta
{
    public class UstaKartlariMap : EntityTypeConfiguration<UstaKartlari>
    {
        public UstaKartlariMap()
        {
            ToTable("UstaKartlariTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.HesapAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Aktif)
              .IsUnicode()
              .HasMaxLength(1);

            Property(u => u.KayitKaynak)
              .IsUnicode()
              .HasMaxLength(40);

            Property(u => u.Kaydeden)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.Degistiren)
              .IsUnicode()
             .HasMaxLength(20);
        }


    }
}
