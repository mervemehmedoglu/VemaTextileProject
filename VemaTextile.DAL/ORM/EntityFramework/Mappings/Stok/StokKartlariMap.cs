using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Stok
{
    public class StokKartlariMap : EntityTypeConfiguration<StokKartlari>
    {
        public StokKartlariMap()
        {
            ToTable("StokKartlariTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.MalKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Birim)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.KartTuru)
              .IsUnicode()
             .HasMaxLength(10);

            Property(u => u.TıpKodu)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.GrupKodu)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.OzelKodu)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.UreticiKodu)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.UreticiUnvan)
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

            Property(u => u.Kod4)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod5)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod6)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod7)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod8)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod9)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Kod10)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Aciklama)
          .IsUnicode()
         .HasMaxLength(50);

            Property(u => u.Aciklama2)
          .IsUnicode()
         .HasMaxLength(50);

            Property(u => u.KDVDahiliHaric1)
          .IsUnicode()
         .HasMaxLength(5);

            Property(u => u.KDVDahiliHaric2)
          .IsUnicode()
         .HasMaxLength(5);

            Property(u => u.KDVDahiliHaric3)
          .IsUnicode()
         .HasMaxLength(5);

            Property(u => u.DovizCinsi1)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.DovizCinsi2)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.DovizCinsi3)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Birim2)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Birim3)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.Birim2lslec)
          .IsUnicode()
         .HasMaxLength(1);

            Property(u => u.Birim3lslec)
          .IsUnicode()
         .HasMaxLength(1);

            Property(u => u.ParaBirimi1)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.ParaBirimi2)
          .IsUnicode()
         .HasMaxLength(20);

            Property(u => u.ParaBirimi3)
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
