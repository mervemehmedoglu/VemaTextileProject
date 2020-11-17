using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutTeklifMap : EntityTypeConfiguration<TaahhutTeklif>
    {
        public TaahhutTeklifMap()
        {
            ToTable("TaahhutTeklifTablosu");
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.HesapAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Telefon1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Telefon2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Telefon3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Marka1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Marka2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Marka3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Marka4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tip1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tip2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tip3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tip4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Model1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Model2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Model3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Model4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kapasite1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kapasite2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kapasite3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kapasite4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Garanti1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Garanti2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Garanti3)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Garanti4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kaydeden)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.Degistiren)
                .HasMaxLength(20)
                .IsUnicode();
        }
    }
}
