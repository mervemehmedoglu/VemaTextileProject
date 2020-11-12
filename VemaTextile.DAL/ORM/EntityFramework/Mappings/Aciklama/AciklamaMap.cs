using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Aciklama
{
    public class AciklamaMap : EntityTypeConfiguration<AciklamaTanimlar>
    {
        public AciklamaMap()
        {
            ToTable("Aciklama Tablosu");

            HasKey(x => x.Parametre1);
            Property(x => x.Parametre1)
                .HasColumnName("Parametre1");

            Property(u => u.Parametre2)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("Parametre2");

            Property(u => u.Aciklama)
               .IsOptional()
               .IsUnicode()
               .HasColumnName("Aciklama");
        }

        
    }
}
