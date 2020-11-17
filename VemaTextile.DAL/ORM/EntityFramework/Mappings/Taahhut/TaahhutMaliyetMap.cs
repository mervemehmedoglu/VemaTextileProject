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
    public class TaahhutMaliyetMap : EntityTypeConfiguration<TaahhutMaliyet>
    {
        public TaahhutMaliyetMap()
        {
            HasKey(x => x.ID);

            Property(u => u.IDMalKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.MalAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.Barkod)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Aciklama)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.EvrakNo)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(2)
                .IsUnicode();

            Property(u => u.IrsaliyeNo)
                .HasMaxLength(8)
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

            Property(u => u.IDCHKKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.CHKAdi)
                .HasMaxLength(50)
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

            Property(u => u.Irsfar)
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
                .HasMaxLength(50)
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