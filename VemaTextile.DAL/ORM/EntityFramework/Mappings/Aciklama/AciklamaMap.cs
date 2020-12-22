using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Aciklama
{
    public class AciklamaMap : EntityTypeConfiguration<AciklamaTanimlar>
    {
        public AciklamaMap()
        {
            ToTable("AciklamaTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.Parametre1)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Parametre2)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.Aciklama)
               .IsOptional()
               .IsUnicode();
               
        }

        
    }
}
