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

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.CHKKodu)
                .HasMaxLength(20);


            Property(u => u.ChkAdi)
                .IsRequired()
                .HasMaxLength(40);


            Property(u => u.EylemGorev)
                .IsRequired()
                .HasMaxLength(5);


            Property(u => u.EylemGorevTipi)
                .IsOptional()
                .HasMaxLength(40);


            Property(u => u.TamamlanmaDurumu)
                .IsOptional()
                .HasMaxLength(5);

            Property(u => u.IlgiliKisi)
                .IsOptional()
                .HasMaxLength(40);


            Property(u => u.Kaydeden)
                .IsRequired()
                .HasMaxLength(20);

        }
    }
}
