using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.CariHesap
{
    public class CariHesapKartlariMap : EntityTypeConfiguration<CariHesapKartlari>
    {
        public CariHesapKartlariMap()
        {
            ToTable("Cari Hesap Kartlari Tablosu");


            HasKey(x => x.HesapKodu);
            Property(x => x.HesapKodu)
                .IsRequired()
                .HasColumnName("Hesap Kodu");

            Property(u => u.HesapAdi)
               .IsRequired()
               .IsUnicode()
               .HasColumnName("Hesap Adi");

            Property(u => u.HesapAdi2)
               .IsOptional()
               .IsUnicode()
               .HasColumnName("Hesap Adi2");

            Property(u => u.KartTipi)
                .IsOptional()
                .IsUnicode()
                .HasMaxLength(15)
                .HasColumnName("Kart Tipi");

            Property(u => u.FaturaAdresi1)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Fatura Adresi1");

            Property(u => u.FaturaAdresi2)
              .IsOptional()
              .IsUnicode()
               .HasMaxLength(50)
              .HasColumnName("Fatura Adresi2");


            Property(u => u.FaturaAdresi3)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Fatura Adresi3");

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
                 .HasColumnName("Web Adresi");

            Property(u => u. VergiDairesi)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(50)
                .HasColumnName("Vergi Dairesi");

            Property(u => u.VergiNo)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Vergi No");

            Property(u => u.IskontoOrani)
                 .IsOptional()
                .HasColumnName("Iskonto Orani");

            Property(u => u.OpsiyonGunu)
                .IsOptional()
               .HasColumnName("Opsiyon Gunu");

            Property(u => u.VergiNo)
                  .IsOptional()
                 .IsUnicode()
                  .HasMaxLength(20)
                 .HasColumnName("Vergi No");

            Property(u => u.DovizCinsi)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Doviz Cinsi");

            Property(u => u.KrediLimiti)
                 .IsOptional()
                .HasColumnName("Kredi Limiti");

            Property(u => u.DovizKrediLimiti)
                .IsOptional()
               .HasColumnName("Doviz Kredi Limiti");

            Property(u => u.BolgeKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Bolge Kodu");

            Property(u => u.OzelKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Ozel Kodu");

            Property(u => u.GrupKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Grup Kodu");

            Property(u => u.TipKodu)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Tip Kodu");

            Property(u => u.Kod1)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod1");

            Property(u => u.Kod2)
                 .IsOptional()
                .IsUnicode()
                 .HasMaxLength(20)
                .HasColumnName("Kod1");

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
               .HasColumnName("Nufus Cuzdan Seri No");

            Property(u => u.TCKimlikNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(11)
               .HasColumnName("TC Kimlik No");

            Property(u => u.AnaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Ana Adi");

            Property(u => u.BabaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Baba Adi");

            Property(u => u.DogumTarihi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("DogumTarihi");

            Property(u => u.DogumYeri)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Dogum Yeri");

            Property(u => u.KefilAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Adi");

            Property(u => u.KefilTelefon)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(11)
               .HasColumnName("KefilTelefon");

            Property(u => u.KefilNufusCuzdanSeriNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Nufus Cuzdan Seri No");

            Property(u => u.KefilTCKimlikNo)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil TC Kimlik No");

            Property(u => u.KefilAnaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Ana Adi");

            Property(u => u.KefilBabaAdi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Baba Adi");

            Property(u => u. KefilDogumTarihi)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Dogum Tarihi");

            Property(u => u.KefilDogumYeri)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(20)
               .HasColumnName("Kefil Dogum Yeri");

            Property(u => u.KefilAdresi1)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Kefil Adresi1");

            Property(u => u.KefilAdresi2)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Kefil Adresi2");

            Property(u => u.TeslimAlan)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(30)
               .HasColumnName("Teslim Alan");

            Property(u => u.TeslimAdresi1)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Teslim Adresi");

            Property(u => u.TeslimAdresi2)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Teslim Adresi2 ");

            Property(u => u.TeslimAdresi3)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(50)
               .HasColumnName("Teslim Adresi3 ");

            Property(u => u.Kaydeden)
                .IsOptional()
               .IsUnicode()
                .HasMaxLength(10)
               .HasColumnName("Kaydeden");

            Property(u => u. KayitTarihi)
               .IsOptional()
              .HasColumnName("Kayit Tarihi");

            Property(u => u.KayitSaati)
               .IsOptional()
              .HasColumnName("Kayit Saati");

            Property(u => u.KayitKaynak)
               .IsOptional()
              .IsUnicode()
               .HasMaxLength(50)
              .HasColumnName("Kayit Kaynak");

            Property(u => u.Degistiren)
               .IsOptional()
              .IsUnicode()
               .HasMaxLength(30)
              .HasColumnName("Degistiren");

            Property(u => u.DegisiklikTarihi)
               .IsOptional()
              .HasColumnName("Degisiklik Tarihi");

            Property(u => u.DegisiklikSaati)
              .IsOptional()
             .HasColumnName("Degisiklik Saati");

            Property(u => u.DegisiklikKaynak)
              .IsOptional()
             .IsUnicode()
              .HasMaxLength(40)
             .HasColumnName("Degisiklik ");

            HasKey(x => x.RowID);
            Property(u => u.RowID)
              .IsOptional()
             .HasColumnName("RowID");













        }


    }

}
