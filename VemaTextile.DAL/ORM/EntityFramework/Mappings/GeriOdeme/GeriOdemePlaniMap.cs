using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.GeriOdeme
{
    public class GeriOdemePlaniMap : EntityTypeConfiguration<GeriOdemePlani>
    {
        public GeriOdemePlaniMap()
        {
            ToTable("GeriOdemePlani");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsRequired()
                .HasMaxLength(50);


            Property(u => u.HesapAdi)
               .IsRequired()
               .HasMaxLength(50);


            Property(u => u.Aciklama)
               .IsOptional()
               .HasMaxLength(50);


            Property(u => u.Tip)
               .IsOptional()
               .HasMaxLength(50);

        }
    }
}
