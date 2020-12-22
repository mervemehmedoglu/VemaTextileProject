using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Stok
{
    public class StokIslemleriMap : EntityTypeConfiguration<StokIslemleri>
    {
        public StokIslemleriMap()
        {
            ToTable("StokIslemleriTablosu");
            HasKey(x => x.ID);

            Property(u => u.MalKodu)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.MalAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.Tarih)
                .IsRequired();

            Property(u => u.EvrakNo)
                .HasMaxLength(17)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(4)
                .IsUnicode();

            Property(u => u.IrsaliyeNo)
                .HasMaxLength(4)
                .IsUnicode();

            Property(u => u.SiparisNo)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.IslemTipi)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.IslemTuru)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Birim)
                 .HasMaxLength(20)
                 .IsUnicode();

            Property(u => u.Birim1)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.DovizTL)
                .HasMaxLength(5)
                .IsUnicode();

            Property(u => u.DovizCinsi)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Irsfat)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.KaynakEvrakTipi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.KDVDahilHaric)
                .HasMaxLength(5)
                .IsUnicode();

            Property(u => u.Depo)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.SeriNo)
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

            Property(u => u.Kod4)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Kod5)
                .HasMaxLength(20)
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
