using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeIslemleriMap : EntityTypeConfiguration<MuhasebeIslemleri>
    {
        public MuhasebeIslemleriMap()
        {
            ToTable("MuhasebeIslemleriTablosu");

            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.HesapKodu)
                .HasMaxLength(50)
                .IsUnicode();

         

            Property(u => u.MaddeNo)
                .IsRequired();

            Property(u => u.VadeTarihi)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.Aciklama)
                .HasMaxLength(100)
                .IsUnicode();

            Property(u => u.IslemTuru)
                .HasMaxLength(6)
                .IsUnicode();

            Property(u => u.FisTipi)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.MasrafMerkeziKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.MasrafMerkeziAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.FisKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kod1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kod2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kod3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.EvrakTipi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.EvrakNo)
                .HasMaxLength(17)
                .IsUnicode();

            Property(u => u.EvrakTarihi)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.EvrakHesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.EvrakHesapAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.DovizTL)
                .HasMaxLength(5)
                .IsUnicode();

            Property(u => u.DovizCinsi)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Ay)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Degistiren)
                .HasMaxLength(20)
                .IsUnicode();
        }
    }

}
