using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutPrimTakibiMap : EntityTypeConfiguration<TaahhutPrimTakibi>
    {
        public TaahhutPrimTakibiMap()
        {
            ToTable("TaahhutPrimTakibiTablosu");
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(2)
                .IsUnicode();

            Property(u => u.FaturaTarihi)
                .HasMaxLength(10)
                .IsUnicode();

            Property(u => u.FaturaNo)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.Unvan)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.CihazMarka)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.CihazTipi)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.CihazModel)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.CihazSeriNo)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.PrimAlinmaDurumu)
                .HasMaxLength(8)
                .IsUnicode();
        }
    }
}
