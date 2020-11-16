using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Odeme
{
    public class OdemePlaniMap : EntityTypeConfiguration<OdemePlani>
    {
        public OdemePlaniMap()
        {
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.HesapKodu)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.HesapKodu)
               .HasMaxLength(8)
               .IsUnicode();

            Property(u => u.Seri)
               .HasMaxLength(2)
               .IsUnicode();

            Property(u => u.OdemeTipi)
               .HasMaxLength(20)
               .IsUnicode();

            Property(u => u.OdemeTarihi)
                .IsRequired();

            Property(u => u.OdemeDurumu)
               .HasMaxLength(10)
               .IsUnicode();

            Property(u => u.Aciklama)
               .HasMaxLength(50)
               .IsUnicode();

             Property(u => u.HesapKodu)
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
        }
    }
}
