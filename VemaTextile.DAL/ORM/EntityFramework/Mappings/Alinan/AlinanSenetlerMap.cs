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
            ToTable("AlinanSenetlerTablosu");


            

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
                .HasColumnName("BorcluUnvan");

            Property(u => u.AlimTarihi)
               .HasColumnName("AlimTarihi");

            Property(u => u.SenediVeren)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("SenediVeren");

            Property(u => u.SenediVerenUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("SenediVerenUnvan");

            Property(u => u.Tutar)
               .HasColumnName("Tutar");

            Property(u => u.TahsilMasrafi)
               .HasColumnName("TahsilMasrafi");

            Property(u => u.SenetTipi)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("SenetTipi");

            Property(u => u.VadeTarihi)
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

            Property(u => u.DovizTL)
               .IsUnicode()
               .HasMaxLength(5)
               .HasColumnName("DovizTL");

            Property(u => u.DovizCinsi)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("DovizCinsi");

            Property(u => u.DovizKuru)
               .HasColumnName("BorcluUnvan");

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

            Property(u => u.SenetNo)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("SenetNo");

            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20)
               .HasColumnName("TahsileCikilanBanka");

            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Tahsile Cikilan Banka");

            Property(u => u.İslemTipi)
               .IsUnicode()
               .HasMaxLength(40)
               .HasColumnName("İslemTipi");

            Property(u => u.Tarih)  
               .HasColumnName("Tarih");

            Property(u => u.SonPozisyon)
               .IsUnicode()
               .HasMaxLength(40)
               .HasColumnName("SonPozisyon");

            Property(u => u.BordroNo)
               .IsUnicode()
               .HasMaxLength(8)
               .HasColumnName("BordroNo");

            HasKey(x => x.BordroIdNo);
            Property(x => x. BordroIdNo)              
               .HasColumnName("BordroSeri");

            Property(u => u.Aciklama)
               .IsUnicode()
               .HasMaxLength(50)
               .HasColumnName("Aciklama");

            HasKey(x => x.IDSenet);
            Property(x => x.IDSenet)
               .HasColumnName("BorcluUnvan");

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
               .HasColumnName("DegisiklikTarihi");

            





        }
    }
}
