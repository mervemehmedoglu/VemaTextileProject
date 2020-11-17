using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeHesapKartlariMap : EntityTypeConfiguration<MuhasebeHesapKartlari>
    {
        public MuhasebeHesapKartlariMap()
        {
            ToTable("MuhasebeHesapKartlariTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapKodu2)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.HesapAdi)
               .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.HesapAdi2)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.KartTipi)
              .IsUnicode()
             .HasMaxLength(15);

            Property(u => u.MasrafMerkeziKodu)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.MasrafMerkeziAdi)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.DovizCinsi)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Kod1)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Kod2)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Kod3)
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
