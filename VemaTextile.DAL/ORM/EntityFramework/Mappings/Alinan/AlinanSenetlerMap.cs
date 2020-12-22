using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;

using System.Security.Cryptography.X509Certificates;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan
{
    public class AlinanSenetlerMap : EntityTypeConfiguration<AlinanSenetler>
    {
        public AlinanSenetlerMap()
        {
            ToTable("AlinanSenetlerTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.HesapKodu)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.HesapAdi)
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.IDSenet)
               .IsUnicode()
               .HasMaxLength(40);

            Property(u => u.Seri)
                .IsUnicode()
                .HasMaxLength(2);


            Property(u => u.Borclu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.BorcluUnvan)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.SenediVeren)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.SenediVerenUnvan)
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.SenetTipi)
               .IsUnicode()
               .HasMaxLength(20);

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


            Property(u => u.DovizTL)
               .IsUnicode()
               .HasMaxLength(5);


            Property(u => u.DovizCinsi)
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


            Property(u => u.SenetNo)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.TahsileCikilanBanka)
               .IsUnicode()
               .HasMaxLength(20);


            Property(u => u.TahsileCikilanBankaUnvan)
               .IsUnicode()
               .HasMaxLength(50);


            Property(u => u.İslemTipi)
               .IsUnicode()
               .HasMaxLength(40);


            Property(u => u.SonPozisyon)
               .IsUnicode()
               .HasMaxLength(40);


            Property(u => u.BordroNo)
               .IsUnicode()
               .HasMaxLength(8);


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
               .IsUnicode();



        }
    }
}
