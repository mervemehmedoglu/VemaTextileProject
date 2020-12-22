using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;



namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeGrupKartlariMap : EntityTypeConfiguration<MuhasebeGrupKartlari>
    {
        public MuhasebeGrupKartlariMap()
        {
            ToTable("MuhasebeGrupKartlariTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapAdi)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.AlimlarHesabi)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.SatislarHesabi)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.AlimdanladelerHesabi)
             .IsUnicode()
            .HasMaxLength(20);


            Property(u => u.SatistanladelerHesabi)
             .IsUnicode()
            .HasMaxLength(20);


            Property(u => u.Diger1)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Diger2)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Diger3)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Diger4)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Diger5)
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
