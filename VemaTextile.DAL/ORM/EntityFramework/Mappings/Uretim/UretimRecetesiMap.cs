using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Uretim
{
    public class UretimRecetesiMap : EntityTypeConfiguration<UretimRecetesi>
    {
        public UretimRecetesiMap()
        {
            ToTable("UretimRecetesiTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.MamulMalKodu)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.MamulMalAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.HammaddeMalKodu)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.HammaddeMalAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.MamulYariMamul)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.Birim)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Birim1)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.MaliyetSekli)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Depo)
               .IsUnicode()
               .HasMaxLength(20);

            Property(u => u.SeriNo)
                .IsUnicode()
                .HasMaxLength(20);

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

            Property(u => u.FireliMalKodu)
                .IsUnicode()
                .HasMaxLength(20);

        }
    }
}
