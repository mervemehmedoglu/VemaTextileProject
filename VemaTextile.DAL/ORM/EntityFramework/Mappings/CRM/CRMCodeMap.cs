using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.CRM
{
    public class CRMCodeMap : EntityTypeConfiguration<CRMCode>
    {
        public CRMCodeMap()
        {
            ToTable("CRMCodeTablosu");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

           
            Property(x => x.KategoriId)
                .IsRequired()
                .HasColumnName("KategoriId");

            Property(u => u.Aciklama)
                .IsOptional()
                .HasMaxLength(40)
                .HasColumnName("Aciklama");

            Property(u => u. Aciklama2)
                .IsOptional()
                .HasMaxLength(400)
                .HasColumnName("Aciklama2");

            Property(u => u.KodTipi)
               .IsOptional()
               .HasColumnName("KodTipi");

            Property(u => u.SiraNo)
               .IsOptional()
               .HasColumnName("SiraNo");
        }
    }
}

