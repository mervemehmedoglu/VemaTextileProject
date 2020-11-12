using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
using System.Security.Cryptography.X509Certificates;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan
{
    public class AlinanSenetlerMap : EntityTypeConfiguration<AlinanSenetler>
    {
        public AlinanSenetlerMap()
        {
            ToTable("Alinan Senetler Tablosu");


            Property(u => u.EvrakNo)
                .HasColumnName("Evrak No");

            Property(u => u.Seri)
                .IsUnicode()
                .HasMaxLength(2)
                .HasColumnName("Seri");

            HasKey(x => x.IDNo);
            Property(x => x.IDNo)
                .HasColumnName("Id No");

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

            Property(u => u.SenediVeren)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Senedi Veren");

            Property(u => u.SenediVerenUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Senedi Veren Unvan");

            Property(u => u.Tutar)
               .HasColumnName("Tutar");

            Property(u => u.TahsilMasrafi)
               .HasColumnName("Tahsil Masrafi");

            Property(u => u.SenetTipi)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Senet Tipi");

            Property(u => u.VadeTarihi)
               .HasColumnName("Vade Tarihi");

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

            Property(u => u.DovizTL)
               .IsUnicode()
               .HasMaxLength(5)
               .HasColumnName("DovizTL");

            Property(u => u.DovizCinsi)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Doviz Cinsi");

            Property(u => u.DovizKuru)
               .HasColumnName("Borclu Unvan");

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

            Property(u => u.SenetNo)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Senet No");

            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("Tahsile Cikilan Banka");

            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Tahsile Cikilan Banka");

            Property(u => u.İslemTipi)
               .IsUnicode()
               .HasMaxLength(40)
               .HasColumnName("İslem Tipi");

            Property(u => u.Tarih)  
               .HasColumnName("Tarih");

            Property(u => u.SonPozisyon)
               .IsUnicode()
               .HasMaxLength(40)
               .HasColumnName("Son Pozisyon");

            Property(u => u.BordroNo)
               .IsUnicode()
               .HasMaxLength(8)
               .HasColumnName("Bordro No");

            HasKey(x => x.BordroIdNo);
            Property(x => x. BordroIdNo)              
               .HasColumnName("Bordro Seri");

            Property(u => u.Aciklama)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Aciklama");

            HasKey(x => x.IDSenet);
            Property(x => x.IDSenet)
               .HasColumnName("Borclu Unvan");

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
               .HasColumnName("Degisiklik Tarihi");

            HasKey(x => x.Row_ID);
            Property(x => x.Row_ID)
               .HasColumnName("Row_ID");





        }
    }
}
