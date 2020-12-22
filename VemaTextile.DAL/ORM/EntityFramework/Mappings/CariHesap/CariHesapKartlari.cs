using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.CariHesap
{
    public class CariHesapKartlariMap : EntityTypeConfiguration<CariHesapKartlari>
    {
        public CariHesapKartlariMap()
        {
            ToTable("CariHesapKartlariTablosu");


            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.HesapKodu)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.HesapAdi)
               .IsRequired()
               .IsUnicode()
               .HasMaxLength(50);


            Property(u => u.HesapAdi2)
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.KartTipi)
                .IsUnicode()
                .HasMaxLength(15);


            Property(u => u.FaturaAdresi1)
               .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.FaturaAdresi2)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.FaturaAdresi3)
               .IsUnicode()
               .HasMaxLength(50);


            Property(u => u.Telefon)
              .IsUnicode()
              .HasMaxLength(15);

            Property(u => u.Telefon2)
             .IsUnicode()
             .HasMaxLength(15);

            Property(u => u.Faks1)
             .IsUnicode()
             .HasMaxLength(15);


            Property(u => u.Faks2)
               .IsUnicode()
               .HasMaxLength(15);


            Property(u => u.Yetkili)
                .IsUnicode()
                .HasMaxLength(30);

            Property(u => u.Email)
                  .IsUnicode()
                 .HasMaxLength(50);


            Property(u => u.WebAdresi)
                 .IsUnicode()
                  .HasMaxLength(70);


            Property(u => u.VergiDairesi)
                .IsUnicode()
                 .HasMaxLength(50);


            Property(u => u.VergiNo)
                .IsUnicode()
                 .HasMaxLength(20);

            Property(u => u.VergiNo)
                 .IsUnicode()
                  .HasMaxLength(20);

            Property(u => u.DovizCinsi)
                .IsUnicode()
                 .HasMaxLength(20);


            Property(u => u.BolgeKodu)
                .IsUnicode()
                 .HasMaxLength(20);


            Property(u => u.OzelKodu)
                 .IsUnicode()
                 .HasMaxLength(20);

            Property(u => u.GrupKodu)
                .IsUnicode()
                 .HasMaxLength(20);


            Property(u => u.TipKodu)
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

            Property(u => u.Aciklama1)
               .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.NufusCuzdanSeriNo)
               .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.TCKimlikNo)
               .IsUnicode()
                .HasMaxLength(11);

            Property(u => u.AnaAdi)
               .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.BabaAdi)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.DogumTarihi)
               .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.DogumYeri)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilAdi)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilTelefon)
               .IsUnicode()
                .HasMaxLength(11);

            Property(u => u.KefilNufusCuzdanSeriNo)
               .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.KefilTCKimlikNo)
               .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.KefilAnaAdi)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilBabaAdi)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilDogumTarihi)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilDogumYeri)
               .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.KefilAdresi1)
               .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.KefilAdresi2)
               .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.TeslimAlan)
               .IsUnicode()
                .HasMaxLength(30);


            Property(u => u.TeslimAdresi1)
               .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.TeslimAdresi2)
               .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.TeslimAdresi3)
               .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.Kaydeden)
               .IsUnicode()
                .HasMaxLength(10);

            Property(u => u.KayitKaynak)
              .IsUnicode()
               .HasMaxLength(50);


            Property(u => u.Degistiren)
              .IsUnicode()
               .HasMaxLength(30);



            Property(u => u.DegisiklikKaynak)
             .IsUnicode()
              .HasMaxLength(40);

        }


    }

}
