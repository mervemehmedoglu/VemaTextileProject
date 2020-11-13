using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan
{
    public class AlinanCeklerMap : EntityTypeConfiguration<AlinanCekler>
    {
        public AlinanCeklerMap()
        {
            ToTable("AlinanCekler");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.Seri)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(2);



            Property(u => u.Borclu)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.BorcluUnvan)
               .IsUnicode()
               .HasMaxLength(50);



            Property(u => u.CekiVeren)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.CekiVerenUnvan)
                .IsUnicode()
                .HasMaxLength(50);



            Property(u => u.CekTipi)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.VadeTarihi)
                .IsRequired();


            Property(u => u.Sehir)
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

            Property(u => u.Banka)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.Sube)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.BankaHesapNo)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.CekNo)
               .IsUnicode()
               .HasMaxLength(20);



            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20);



            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50);
            Property(u => u.IslemTipi)
               .IsUnicode()
               .HasMaxLength(40);


            Property(u => u.SonPozisyon)
              .IsUnicode()
              .HasMaxLength(40);


            Property(u => u.BordroSeri)
              .IsUnicode()
              .HasMaxLength(2);


            Property(u => u.BordroIdNo)
              .IsOptional();


            Property(u => u.Aciklama)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.HesapKodu)
              .IsUnicode()
              .HasMaxLength(20);


            Property(u => u.HesapAdi)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.Kaydeden)
              .IsUnicode()
              .HasMaxLength(10);

            Property(u => u.Degistiren)
            .IsUnicode()
            .HasMaxLength(10);


            
        }
    


    }
}
