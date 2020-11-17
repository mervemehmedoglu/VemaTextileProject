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
    public class TaahhutAciklamaMap : EntityTypeConfiguration<TaahhutAciklama>
    {
        public TaahhutAciklamaMap()
        {
            ToTable("TaahhutAciklamaTablosu");
            HasKey(x => x.ID);

            Property(u => u.EvrakNo)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.Ok)
                .HasMaxLength(1)
                .IsUnicode();

            Property(u => u.Aciklama)
                .HasMaxLength(200)
                .IsUnicode();


        }
    }
}

