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
            ToTable("Cari Hesap İslemleri Tablosu");


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
               .HasColumnName("Id No");

            Property(u => u.Tarih)
               .IsOptional()
               .HasColumnName("Tarih");

            Property(u => u.OpsiyonGunu)
               .IsOptional()
               .HasColumnName("Opsiyon Gunu");

            Property(u => u.VadeTarihi)
               .IsOptional()
               .HasColumnName("Vade Tarihi");

            Property(u => u.IslemTuru)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(4)
               .HasColumnName("Islem Turu");

            Property(u => u.KaynakEvrakTipi)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(4)
               .HasColumnName("Kaynak Evrak Tipi");


            Property(u => u.HesapKodu)
                .IsRequired()
               .IsOptional()
               .IsUnicode()
               .HasColumnName("Hesap Kodu");

            Property(u => u.HesapAdi)
              .IsRequired()
             .IsOptional()
             .IsUnicode()
             .HasColumnName("Hesap Adi");

            Property(u => u.DovizTL)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(5)
               .HasColumnName("Doviz TL");

            Property(u => u.Tutar)
              .HasColumnName("Tutar");


            Property(u => u.DovizCinsi)
               .IsUnicode()
                .HasMaxLength(5)
               .HasColumnName("Doviz Cinsi");

            Property(u => u.DovizKuru)
             .HasColumnName("Doviz Kuru");

            Property(u => u.DovizTutar)
             .HasColumnName("Doviz Tutar");

            Property(u => u.KDVTutar)
             .HasColumnName("Kdv Tutar");

            Property(u => u.OTVTutar)
             .HasColumnName("Otv Tutar");

            Property(u => u.IskontoTutar)
             .HasColumnName("Iskonto Tutar");

            Property(u => u.DovizCinsi)
              .IsUnicode()
               .HasMaxLength(5)
              .HasColumnName("Doviz Cinsi");

            Property(u => u.PesinVadeli)
             .IsUnicode()
              .HasMaxLength(20)
             .HasColumnName("Peşin Vadeli");

            Property(u => u.KarsiHesapKodu)
            .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("Karsi Hesap Kodu");

            Property(u => u.KarsiHesapAdi)
            .IsUnicode()
             .HasMaxLength(50)
            .HasColumnName("Karsi Hesap Adi");

            Property(u => u.BakiyeEtkisi)
            .IsUnicode()
             .HasMaxLength(3)
            .HasColumnName("Bakiye Etkisi");

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
            .HasColumnName("Kayit Tarihi");

            Property(u => u.DegisiklikTarihi)
            .HasColumnName("Degisiklik Tarihi");

            Property(u => u.IDHesapKodu)
                .IsUnicode()
             .HasMaxLength(20)
            .HasColumnName("ID Hesap Kodu");

            Property(u => u.Row_ID)
            .IsRequired()
           .HasColumnName("ID Hesap Kodu");
        }


    }
}
