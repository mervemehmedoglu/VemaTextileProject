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
            ToTable("CRMCode");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.Aciklama)
                .IsOptional()
                .HasMaxLength(40);


            Property(u => u.Aciklama2)
                .IsOptional()
                .HasMaxLength(400);

            Property(u => u.KodTipi)
               .IsOptional();


            Property(u => u.SiraNo)
               .IsOptional();
           

        }
    }
}

