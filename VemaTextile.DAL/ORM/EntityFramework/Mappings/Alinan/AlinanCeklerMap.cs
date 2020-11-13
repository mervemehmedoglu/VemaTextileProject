using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan
{
    public class AlinanCeklerMap : EntityTypeConfiguration<AlinanCekler>
    {
        public AlinanCeklerMap()
        {
            ToTable("AlinanCeklerTablosu");

            HasKey(x => x.EvrakNo);
            Property(x => x.EvrakNo)
                .HasColumnName("EvrakNo");

            Property(u => u.Seri)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(2)
                .HasColumnName("Seri");

            Property(u => u.IdNo)
                .IsRequired()
                .HasColumnName("IdNo");

            Property(u => u.Borclu)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Borclu");

            Property(u => u.BorcluUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("BorcluUnvan");

            Property(u => u.AlimTarihi)
               .HasColumnName("AlimTarihi");

            Property(u => u.CekiVeren)
                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("CekiVeren");

            Property(u => u.CekiVerenUnvan)
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("CekiVerenUnvan");

            Property(u => u.Tutar)
                .HasColumnName("Tutar");

            Property(u => u.TahsilMasrafi)
                .HasColumnName("TahsilMasrafi");


            Property(u => u.CekTipi)

                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("CekTipi");

            Property(u => u.VadeTarihi)
                .IsRequired()
                .HasColumnName("VadeTarihi");

            Property(u => u.Sehir)
                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("Sehir");

            Property(u => u.Kod1)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod1");

            Property(u => u.Kod2)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod2");

            Property(u => u.Kod3)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod3");

            Property(u => u.DovizTutar)
               .HasColumnName("DovizTutar");

            Property(u => u.DovizCinsi)
               .HasColumnName("DovizCinsi");

            Property(u => u.DovizKuru)
               .HasColumnName("DovizKuru");

            Property(u => u.DovizTutar)
               .HasColumnName("DovizTutar");

            Property(u => u.Banka)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Banka");

            Property(u => u.Sube)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Sube");

            Property(u => u.BankaHesapNo)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("BankaHesapNo");

            Property(u => u.CekNo)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("CekNo");

            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("TahsileCikilanBanka");

            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("TahsileCikilanBankaUnvan");


            Property(u => u.IslemTipi)
               .IsUnicode()
               .HasMaxLength(40);

            Property(u => u.Tarih)
               .HasColumnName("Tarih");

            Property(u => u.SonPozisyon)
              .IsUnicode()
              .HasMaxLength(40)
              .HasColumnName("SonPozisyon");

            Property(u => u.BordroNo)
              .IsUnicode()
              .HasMaxLength(8)
              .HasColumnName("BordroNo ");

            Property(u => u.BordroSeri)
              .IsUnicode()
              .HasMaxLength(2)
              .HasColumnName("BordroSeri");

            Property(u => u.BordroIdNo)
              .IsOptional()
              .HasColumnName("IslemTipi");

            Property(u => u.Aciklama)
              .IsUnicode()
              .HasMaxLength(50)
              .HasColumnName("Aciklama");

            Property(u => u.IDCek)
              .HasColumnName("IDCek");

            Property(u => u.HesapKodu)
              .IsUnicode()
              .HasMaxLength(20)
              .HasColumnName("HesapKodu");

            Property(u => u.HesapAdi)
              .IsUnicode()
              .HasMaxLength(50)
              .HasColumnName("HesapAdi");

            Property(u => u.Kaydeden)
              .IsUnicode()
              .HasMaxLength(10)
              .HasColumnName("Kaydeden");

            Property(u => u.KayitTarihi)
            .HasColumnName("KayitTarihi");

            Property(u => u.Degistiren)
            .IsUnicode()
            .HasMaxLength(10)
            .HasColumnName("Degistiren");

            Property(u => u.DegisiklikTarihi)
            .HasColumnName("DegistirenTarihi ");

            
        }
    


    }
}
