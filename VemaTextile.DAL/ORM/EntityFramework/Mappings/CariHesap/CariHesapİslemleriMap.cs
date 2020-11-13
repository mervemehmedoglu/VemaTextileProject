using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.CariHesap
{
    public class CariHesapİslemleriMap : EntityTypeConfiguration<CariHesapİslemleri>
    {
        public CariHesapİslemleriMap()
        {
            ToTable("CariHesapIslemleriTablosu");

            Property(u => u.EvrakNo)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(57)
                .HasColumnName("Evrak No");

            Property(u => u.Seri)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(4)
               .HasColumnName("Seri");

            Property(u => u.IdNo)
               .IsOptional()
               .HasColumnName("IdNo");

            Property(u => u.Tarih)
               .IsOptional()
               .HasColumnName("Tarih");

            Property(u => u.OpsiyonGunu)
               .IsOptional()
               .HasColumnName("OpsiyonGunu");

            Property(u => u.VadeTarihi)
               .IsOptional()
               .HasColumnName("VadeTarihi");

            Property(u => u.IslemTuru)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(4)
               .HasColumnName("IslemTuru");

            Property(u => u.KaynakEvrakTipi)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(4)
               .HasColumnName("KaynakEvrakTipi");


            Property(u => u.HesapKodu)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
               .HasColumnName("HesapKodu");

            Property(u => u.HesapAdi)
              .IsRequired()
             .IsOptional()
             .IsUnicode()
             .HasColumnName("HesapAdi");

            Property(u => u.DovizTL)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(5)
               .HasColumnName("DovizTL");

            Property(u => u.Tutar)
              .HasColumnName("Tutar");


            Property(u => u.DovizCinsi)
               .IsUnicode()
                .HasMaxLength(5)
               .HasColumnName("DovizCinsi");

            Property(u => u.DovizKuru)
             .HasColumnName("DovizKuru");

            Property(u => u.DovizTutar)
             .HasColumnName("DovizTutar");

            Property(u => u.KDVTutar)
             .HasColumnName("KdvTutar");

            Property(u => u.OTVTutar)
             .HasColumnName("OtvTutar");

            Property(u => u.IskontoTutar)
             .HasColumnName("IskontoTutar");

            Property(u => u.DovizCinsi)
              .IsUnicode()
               .HasMaxLength(5)
              .HasColumnName("DovizCinsi");

            Property(u => u.PesinVadeli)
             .IsUnicode()
              .HasMaxLength(20)
             .HasColumnName("PeşinVadeli");

            Property(u => u.KarsiHesapKodu)
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("KarsiHesapKodu");

            Property(u => u.KarsiHesapAdi)
            .IsUnicode()
             .HasMaxLength(50)
            .HasColumnName("KarsiHesapAdi");

            Property(u => u.BakiyeEtkisi)
            .IsUnicode()
             .HasMaxLength(3)
            .HasColumnName("BakiyeEtkisi");

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

            Property(u => u.Kod4)
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("Kod4");

            Property(u => u.Kod5)
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("Kod5");

            Property(u => u.Aciklama)
            .IsUnicode()
             .HasMaxLength(100)
            .HasColumnName("Aciklama");

            Property(u => u.Kaydeden)
             .IsRequired()
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("Kaydeden");

            Property(u => u.Degistiren)
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("Degistiren");

            Property(u => u.KayitTarihi)
            .HasColumnName("KayitTarihi");

            Property(u => u.DegisiklikTarihi)
            .HasColumnName("DegisiklikTarihi");

            Property(u => u.IDHesapKodu)
                .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("IDHesapKodu");

            
        }


    }
}
