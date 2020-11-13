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

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapAdi)
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.EvrakNo)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(57);

            Property(u => u.Seri)
               .IsOptional()
               .IsUnicode()
               .HasMaxLength(4);


            Property(u => u.IslemTuru)
               .IsUnicode()
                .HasMaxLength(4);


            Property(u => u.KaynakEvrakTipi)
               .IsUnicode()
               .HasMaxLength(4);

            Property(u => u.DovizTL)
               .IsOptional()
               .IsUnicode()
                .HasMaxLength(5);


            Property(u => u.DovizCinsi)
               .IsUnicode()
                .HasMaxLength(5)
               .HasColumnName("DovizCinsi");



            Property(u => u.DovizCinsi)
              .IsUnicode()
               .HasMaxLength(5);


            Property(u => u.PesinVadeli)
             .IsUnicode()
              .HasMaxLength(20);


            Property(u => u.KarsiHesapKodu)
            .IsUnicode()
             .HasMaxLength(20);


            Property(u => u.KarsiHesapAdi)
            .IsUnicode()
             .HasMaxLength(50);


            Property(u => u.BakiyeEtkisi)
            .IsUnicode()
             .HasMaxLength(3);


            Property(u => u.Kod1)
            .IsUnicode()
             .HasMaxLength(20);


            Property(u => u.Kod2)
            .IsUnicode()
             .HasMaxLength(20);


            Property(u => u.Kod3)
            .IsUnicode()
             .HasMaxLength(20);


            Property(u => u.Kod4)
            .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Kod5)
            .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Aciklama)
            .IsUnicode()
             .HasMaxLength(100);


            Property(u => u.Kaydeden)
            .IsUnicode()
             .HasMaxLength(20);


            Property(u => u.Degistiren)
            .IsUnicode()
             .HasMaxLength(20);

        
            
        }


    }
}
