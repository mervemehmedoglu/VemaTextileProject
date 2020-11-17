using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeIsletmeKodlariMap : EntityTypeConfiguration<MuhasebeIsletmeKodlari>
    {
        public MuhasebeIsletmeKodlariMap()
        {
            ToTable("MuhasebeIsletmeKodlariTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapAdi)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.Aciklama)
               .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.KdvDahilHaric)
              .IsUnicode()
             .HasMaxLength(5);

            Property(u => u.DBTutar)
              .IsRequired();

            Property(u => u.DBKdv)
             .IsRequired();

            Property(u => u.DBMiktar)
             .IsRequired();

            Property(u => u.DSTutar)
             .IsRequired();

            Property(u => u.DSKdv)
            .IsRequired();

            Property(u => u.DSMiktar)
            .IsRequired();

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
