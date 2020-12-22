using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Proje
{
    public class ProjeGorevAciklamaMap : EntityTypeConfiguration<ProjeGorevAciklama>
    {
        public ProjeGorevAciklamaMap()
        {
            ToTable("ProjeGorevAciklamaTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.Kullanan)
                .IsUnicode()
                .HasMaxLength(20);

        }


    }
}
