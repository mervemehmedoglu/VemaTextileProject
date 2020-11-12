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
            ToTable("Eylem ve Gorevler Tablosu");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            Property(u => u.ChkKodu)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Chk Kodu");

            Property(u => u.ChkAdi)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("Chk Adi");

            Property(u => u.EylemGorev)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("Chk Kodu");

            Property(u => u.EylemGorevTipi)
                .IsOptional()
                .HasMaxLength(40)
                .HasColumnName("Eylem Gorev Tipi");

            Property(u => u.TamamlanmaDurumu)
                .IsOptional()
                .HasMaxLength(5)
                .HasColumnName("Tamamlanma Durumu");

            Property(u => u.IlgiliKisi)
                .IsOptional()
                .HasMaxLength(40)
                .HasColumnName("Ilgili Kisi");

            Property(u => u.Kaydeden)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Kaydeden");

            Property(u => u.Tarih)
                .IsOptional()
                .HasColumnName("Tarih");

            Property(u => u.GorevTamamlamaTarihi)
                .IsOptional()
                .HasColumnName("Gorev Tamamlama Tarihi");

            Property(u => u.BitisTarihi)
                .IsOptional()
                .HasColumnName("Bitis Tarihi");

            Property(u => u.KayitTarihi)
                .IsOptional()
                .HasColumnName("Kayit Tarihi");

            Property(u => u.Aciklama)
                .IsOptional()
                .HasColumnName("Aciklama");

        }
    }
}
