using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Muhasebe
{
    public class MuhasebeMasrafMerkeziKartlariMap : EntityTypeConfiguration<MuhasebeMasrafMerkeziKartlari>
    {
        public MuhasebeMasrafMerkeziKartlariMap()
        {
            ToTable("MuhasebeMasrafMerkeziKartlariTablosu");
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.HesapKodu2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.HesapAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.HesapAdi2)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.DovizCinsi)
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

            Property(u => u.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Degistiren)
                .HasMaxLength(10)
                .IsUnicode();

        }
    }
}
