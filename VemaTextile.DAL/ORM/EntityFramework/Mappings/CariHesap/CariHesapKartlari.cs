using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.CariHesap
{
    public class CariHesapKartlariMap : EntityTypeConfiguration<CariHesapKartlari>
    {
        public CariHesapKartlariMap()
        {
            ToTable("CariHesapKartlariTablosu");


            

            Property(u => u.HesapAdi)
               .IsRequired()
               .IsUnicode()
               .HasColumnName("HesapAdi");

            Property(u => u.HesapAdi2)
               .IsOptional()
               .IsUnicode()
               .HasColumnName("HesapAdi2");

            Property(u => u.KartTipi)
                .IsOptional()
                .IsUnicode()
                .HasMaxLength(15)
                .HasColumnName("KartTipi");

            Property(u => u.FaturaAdresi1)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("FaturaAdresi1");

            Property(u => u.FaturaAdresi2)
              .IsOptional()
              .IsUnicode()
               .HasMaxLength(50)
              .HasColumnName("FaturaAdresi2");


            Property(u => u.FaturaAdresi3)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("FaturaAdresi3");

            Property(u => u.Telefon)
              .IsOptional()
              .IsUnicode()
               .HasMaxLength(15)
              .HasColumnName("Telefon");

            Property(u => u.Telefon2)
             .IsOptional()
             .IsUnicode()
              .HasMaxLength(15)
             .HasColumnName("Telefon2");

            Property(u => u.Faks1)
             .IsOptional()
             .IsUnicode()
              .HasMaxLength(15)
             .HasColumnName("Faks1");

            Property(u => u.Faks2)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(15)
               .HasColumnName("Faks2");

            Property(u => u.Yetkili)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(30)
                .HasColumnName("Yetkili");

            Property(u => u.Email)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(50)
                .HasColumnName("Email");

            Property(u => u.WebAdresi)
                  .IsOptional()
                 .IsUnicode()
                  .HasMaxLength(70)
                 .HasColumnName("WebAdresi");

            Property(u => u. VergiDairesi)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(50)
                .HasColumnName("VergiDairesi");

            Property(u => u.VergiNo)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("VergiNo");

            Property(u => u.IskontoOrani)
                 .IsOptional()
                .HasColumnName("IskontoOrani");

            Property(u => u.OpsiyonGunu)
                .IsOptional()
               .HasColumnName("OpsiyonGunu");

            Property(u => u.VergiNo)
                  .IsOptional()
                 .IsUnicode()
                  .HasMaxLength(20)
                 .HasColumnName("VergiNo");

            Property(u => u.DovizCinsi)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("DovizCinsi");

            Property(u => u.KrediLimiti)
                 .IsOptional()
                .HasColumnName("KrediLimiti");

            Property(u => u.DovizKrediLimiti)
                .IsOptional()
               .HasColumnName("DovizKrediLimiti");

            Property(u => u.BolgeKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("BolgeKodu");

            Property(u => u.OzelKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("OzelKodu");

            Property(u => u.GrupKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("GrupKodu");

            Property(u => u.TipKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("TipKodu");

            Property(u => u.Kod1)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod1");

            Property(u => u.Kod2)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod2");

            Property(u => u.Kod3)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod3");

            Property(u => u.Kod4)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod4");

            Property(u => u.Kod5)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod5");

            Property(u => u.Kod6)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod6");

            Property(u => u.Kod7)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod7");

            Property(u => u.Kod8)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod8");

            Property(u => u.Kod9)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod9");

            Property(u => u.Kod10)
                 .IsOptional()
                .HasColumnName("Kod10");

            Property(u => u.Kod11)
                .IsOptional()
               .HasColumnName("Kod11");

            Property(u => u.Kod12)
                .IsOptional()
               .HasColumnName("Kod12");

            Property(u => u.Kod13)
                .IsOptional()
               .HasColumnName("Kod13");

            Property(u => u.Kod14)
                .IsOptional()
               .HasColumnName("Kod14");

            Property(u => u.Aciklama1)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Aciklama1");

            Property(u => u.Aciklama2)
              .IsOptional()
             .HasColumnName("Aciklama2");

            Property(u => u.NufusCuzdanSeriNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("NufusCuzdanSeriNo");

            Property(u => u.TCKimlikNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(11)
               .HasColumnName("TCKimlikNo");

            Property(u => u.AnaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("AnaAdi");

            Property(u => u.BabaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("BabaAdi");

            Property(u => u.DogumTarihi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("DogumTarihi");

            Property(u => u.DogumYeri)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("DogumYeri");

            Property(u => u.KefilAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilAdi");

            Property(u => u.KefilTelefon)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(11)
               .HasColumnName("KefilTelefon");

            Property(u => u.KefilNufusCuzdanSeriNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilNufusCuzdanSeriNo");

            Property(u => u.KefilTCKimlikNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilTCKimlikNo");

            Property(u => u.KefilAnaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilAnaAdi");

            Property(u => u.KefilBabaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilBabaAdi");

            Property(u => u. KefilDogumTarihi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilDogumTarihi");

            Property(u => u.KefilDogumYeri)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("KefilDogumYeri");

            Property(u => u.KefilAdresi1)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("KefilAdresi1");

            Property(u => u.KefilAdresi2)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("KefilAdresi2");

            Property(u => u.TeslimAlan)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(30)
               .HasColumnName("TeslimAlan");

            Property(u => u.TeslimAdresi1)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("TeslimAdresi");

            Property(u => u.TeslimAdresi2)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("TeslimAdresi2 ");

            Property(u => u.TeslimAdresi3)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("TeslimAdresi3 ");

            Property(u => u.Kaydeden)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(10)
               .HasColumnName("Kaydeden");

            Property(u => u. KayitTarihi)
               .IsOptional()
              .HasColumnName("KayitTarihi");

            Property(u => u.KayitSaati)
               .IsOptional()
              .HasColumnName("KayitSaati");

            Property(u => u.KayitKaynak)
               .IsOptional()
              .IsUnicode()
               .HasMaxLength(50)
              .HasColumnName("KayitKaynak");

            Property(u => u.Degistiren)
               .IsOptional()
              .IsUnicode()
               .HasMaxLength(30)
              .HasColumnName("Degistiren");

            Property(u => u.DegisiklikTarihi)
               .IsOptional()
              .HasColumnName("DegisiklikTarihi");

            Property(u => u.DegisiklikSaati)
              .IsOptional()
             .HasColumnName("DegisiklikSaati");

            Property(u => u.DegisiklikKaynak)
              .IsOptional()
             .IsUnicode()
              .HasMaxLength(40)
             .HasColumnName("Degisiklik");

        }


    }

}
