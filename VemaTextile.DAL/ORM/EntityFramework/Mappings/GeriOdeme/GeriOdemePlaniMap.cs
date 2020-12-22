using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.GeriOdeme
{
    public class GeriOdemePlaniMap : EntityTypeConfiguration<GeriOdemePlani>
    {
        public GeriOdemePlaniMap()
        {
            ToTable("GeriOdemePlaniTablosu");

            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.HesapAdi)
               .IsRequired()
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.Aciklama)
               .IsUnicode()
               .HasMaxLength(50);

            Property(u => u.Tip)
               .IsUnicode()
               .HasMaxLength(50);

        }
    }
}
