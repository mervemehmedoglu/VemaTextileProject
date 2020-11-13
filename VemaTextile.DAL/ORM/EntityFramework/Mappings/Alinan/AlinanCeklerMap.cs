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

            Property(u => u.EvrakNo)
                .IsRequired();

            Property(u => u.Seri)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(2)
                .HasColumnName("Seri");

            

            Property(u => u.Borclu)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Borclu");

            Property(u => u.BorcluUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Borclu Unvan");

            Property(u => u.AlimTarihi)
               .HasColumnName("Alim Tarihi");

            Property(u => u.CekiVeren)
                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("Ceki Veren");

            Property(u => u.CekiVerenUnvan)
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("Ceki Veren Unvan");

            Property(u => u.Tutar)
                .HasColumnName("Tutar");

            Property(u => u.TahsilMasrafi)
                .HasColumnName("Tahsil Masrafi");


            Property(u => u.CekTipi)

                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("Cek Tipi");

            Property(u => u.VadeTarihi)
                .IsRequired()
                .HasColumnName("Vade Tarihi");

            Property(u => u.Sehir)
                .IsUnicode()
                .HasMaxLength(20)
                .HasColumnName("Sehir");

            Property(u => u.Kod1)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod 1");

            Property(u => u.Kod2)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod 2");

            Property(u => u.Kod3)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Kod 3");

            Property(u => u.DovizTutar)
               .HasColumnName("Doviz Tutar");

            Property(u => u.DovizCinsi)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Doviz Cinsi");

            Property(u => u.DovizKuru)
               .HasColumnName("Doviz Kuru");

            Property(u => u.DovizTutar)
               .HasColumnName("Doviz Tutar");

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
               .HasColumnName("Banka Hesap No");

            Property(u => u.CekNo)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Cek No");

            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Tahsile Cikilan Banka");

            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Tahsile Cikilan Banka Unvan");


            Property(u => u.IslemTipi)
               .IsUnicode()
               .HasMaxLength(40);

            Property(u => u.Tarih)
               .HasColumnName("Tarih");

            Property(u => u.SonPozisyon)
              .IsUnicode()
              .HasMaxLength(40)
              .HasColumnName("Son Pozisyon");

            Property(u => u.BordroNo)
              .IsUnicode()
              .HasMaxLength(8)
              .HasColumnName("Bordro No ");

            Property(u => u.BordroSeri)
              .IsUnicode()
              .HasMaxLength(2)
              .HasColumnName("Bordro Seri");

            Property(u => u.BordroIdNo)
              .IsOptional()
              .HasColumnName("Islem Tipi");

            Property(u => u.Aciklama)
              .IsUnicode()
              .HasMaxLength(50)
              .HasColumnName("Aciklama ");

            Property(u => u.IDCek)
              .HasColumnName("ID Cek");

            Property(u => u.HesapKodu)
              .IsUnicode()
              .HasMaxLength(20)
              .HasColumnName("Hesap Kodu");

            Property(u => u.HesapAdi)
              .IsUnicode()
              .HasMaxLength(50)
              .HasColumnName("Hesap Adi");

            Property(u => u.Kaydeden)
              .IsUnicode()
              .HasMaxLength(10)
              .HasColumnName("Kaydeden");

            Property(u => u.KayitTarihi)
            .HasColumnName("Kayit Tarihi");

            Property(u => u.Degistiren)
            .IsUnicode()
            .HasMaxLength(10)
            .HasColumnName("Degistiren");

            Property(u => u.DegisiklikTarihi)
            .HasColumnName("Degistiren Tarihi ");

           
        }
    


    }
}
