using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Kullanici
{
    public class KullanicilarMap : EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            ToTable("KullanicilarTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.KullaniciAdi)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Sifre)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.Kaydeden)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.Degistiren)
              .IsUnicode()
             .HasMaxLength(20);
        }


    }
}
