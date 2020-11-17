using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutKesifOzetiMap : EntityTypeConfiguration<TaahhutKesifOzeti>
    {
        public TaahhutKesifOzetiMap()
        {
            ToTable("TaahhutKesifOzetiTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.CHKKodu)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);


            Property(u => u.Seri)
               .IsUnicode()
              .HasMaxLength(2);

            Property(u => u.CHKAdi)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.CHKAdi2)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Adres1)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Adres2)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Adres3)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Telefon)
             .IsUnicode()
            .HasMaxLength(15);

            Property(u => u.Telefon2)
             .IsUnicode()
            .HasMaxLength(15);

            Property(u => u.TcKimlikNo)
             .IsUnicode()
            .HasMaxLength(11);

            Property(u => u.KesifAlan)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.KesfeGiden)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Referans)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Netice)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.AnlasmaYapildi)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Notlar)
             .IsUnicode()
            .HasMaxLength(100);

            Property(u => u.Aciklama)
             .IsUnicode()
            .HasMaxLength(100);

            Property(u => u.Kaydeden)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.KdvOtomatik)
             .IsUnicode()
            .HasMaxLength(5);


        }


    }
}
