using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.EylemveGorev
{
    public class EylemVeGorevlerMap : EntityTypeConfiguration<EylemVeGorevler>
    {
        public EylemVeGorevlerMap()
        {
            ToTable("EylemveGorevlerTablosu");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            Property(u => u.ChkKodu)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("ChkKodu");

            Property(u => u.ChkAdi)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("ChkAdi");

            Property(u => u.EylemGorev)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("EylemGorevKodu");

            Property(u => u.EylemGorevTipi)
                .IsOptional()
                .HasMaxLength(40)
                .HasColumnName("EylemGorevTipi");

            Property(u => u.TamamlanmaDurumu)
                .IsOptional()
                .HasMaxLength(5)
                .HasColumnName("TamamlanmaDurumu");

            Property(u => u.IlgiliKisi)
                .IsOptional()
                .HasMaxLength(40)
                .HasColumnName("IlgiliKisi");

            Property(u => u.Kaydeden)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Kaydeden");

            Property(u => u.Tarih)
                .IsOptional()
                .HasColumnName("Tarih");

            Property(u => u.GorevTamamlamaTarihi)
                .IsOptional()
                .HasColumnName("GorevTamamlamaTarihi");

            Property(u => u.BitisTarihi)
                .IsOptional()
                .HasColumnName("BitisTarihi");

            Property(u => u.KayitTarihi)
                .IsOptional()
                .HasColumnName("KayitTarihi");

            Property(u => u.Aciklama)
                .IsOptional()
                .HasColumnName("Aciklama");

        }
    }
}
