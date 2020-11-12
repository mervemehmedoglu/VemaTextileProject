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
            ToTable("CRMCode  Tablosu");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id");

            HasKey(x => x.KategoriId);
            Property(x => x.KategoriId)
                .IsRequired()
                .HasColumnName("Kategori Id");

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
               .HasColumnName("Kod Tipi");

            Property(u => u.SiraNo)
               .IsOptional()
               .HasColumnName("Sira No");

            HasKey(x => x.Row_ID);
            Property(x => x.Row_ID)
               .IsRequired()
               .HasColumnName("Row Id");


        }
    }
}

