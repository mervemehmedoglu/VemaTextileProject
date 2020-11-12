using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan
{
    public class AlinanCeklerMap : EntityTypeConfiguration<AlinanCekler>
    {
        public AlinanCeklerMap()
        {
            ToTable("Aciklama Tablosu");

            HasKey(x => x.EvrakNo);
            Property(x => x.EvrakNo)
                .HasColumnName("Evrak No");

            Property(u => u.Seri)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(2)
                .HasColumnName("Seri");

            Property(u => u.IdNo)
               .IsOptional()
               .IsUnicode()
               .HasColumnName("Id No");
        }


    }
}
