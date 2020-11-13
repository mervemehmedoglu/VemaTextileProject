using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.FaturaBilgi
{
    public class FaturaBilgiMap : EntityTypeConfiguration<FaturaBilgileri>
    {
        public FaturaBilgiMap()
        {
            ToTable("FaturaBilgiTablosu");

            Property(u => u.Tarih)
                .IsOptional()
                .HasColumnName("Tarih");

            Property(u => u.CHKKodu)
                .IsOptional()
               .HasColumnName("CHKKodu");

            Property(u => u.CHKAdi)
                .IsOptional()
               .HasColumnName("CHKAdi");

            Property(u => u.Tıp)
                .IsRequired()
                .HasMaxLength(30)
               .HasColumnName("Tıp");

            Property(u => u.Tutar)
                .IsOptional()
               .HasColumnName("Tutar");

            Property(u => u.Oran)
                .IsOptional()
               .HasColumnName("Oran");

            Property(u => u.DovizTL)
                .IsOptional()
                .HasMaxLength(10)
               .HasColumnName("DovizTL");

            Property(u => u.DovizCinsi)
                .IsOptional()
                .HasMaxLength(20)
               .HasColumnName("DovizCinsi");

            Property(u => u.DovizKuru)
                .IsOptional() 
               .HasColumnName("DovizKuru");

            Property(u => u.DovizTutar)
                .IsOptional()
               .HasColumnName("DovizTutar");

            Property(u => u.Kod1)
                .IsOptional()
                .HasMaxLength(20)
               .HasColumnName("Kod1");

            Property(u => u.Kod2)
                .IsOptional()
                .HasMaxLength(20)
               .HasColumnName("kod2");

            Property(u => u.Kod3)
              .IsOptional()
              .HasMaxLength(20)
             .HasColumnName("Kod3");

            Property(u => u.Kod4)
              .IsOptional()
             .HasColumnName("Kod4");

            Property(u => u.Kod5)
              .IsOptional()
             .HasColumnName("Kod5");

            Property(u => u.TeslimAdres1)
              .IsOptional()
              .HasMaxLength(50)
             .HasColumnName("TeslimAdresi1");

            Property(u => u.TeslimAdres2)
              .IsOptional()
              .HasMaxLength(50)
             .HasColumnName("TeslimAdresi2");

            Property(u => u.TeslimAdres3)
              .IsOptional()
              .HasMaxLength(50)
             .HasColumnName("TeslimAdresi3");

            Property(u => u.Aciklama1)
              .IsOptional()
              .HasMaxLength(50)
             .HasColumnName("Aciklama1");

            Property(u => u.Aciklama2)
              .IsOptional()
              .HasMaxLength(50)
             .HasColumnName("Aciklama2");

            Property(u => u.KDVHesaplama)
              .IsOptional()
              .HasMaxLength(10)
             .HasColumnName("KDVHesaplama");

            Property(u => u.KaynakEvrakTipi)
              .IsRequired()
              .HasMaxLength(50)
             .HasColumnName("KaynakEvrakTipi");

            
        }
    }
}
