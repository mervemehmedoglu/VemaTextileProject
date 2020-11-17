using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Teklif
{
    public class TeklifAciklamaMap : EntityTypeConfiguration<TeklifAciklama>
    {
        public TeklifAciklamaMap()
        {
            ToTable("TeklifAciklamaTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.Seri)
                .IsUnicode()
                .HasMaxLength(2);


            Property(u => u.Ok)
               .IsUnicode()
              .HasMaxLength(1);

            Property(u => u.Aciklama)
              .IsUnicode()
             .HasMaxLength(200);
        }


    }
}
