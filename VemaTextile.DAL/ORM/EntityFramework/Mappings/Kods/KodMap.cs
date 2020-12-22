using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;



namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Kods
{
    public class KodMap : EntityTypeConfiguration<KOD>
    {
        public KodMap()
        {
            ToTable("KodTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.IslemKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Tıp)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.Kod)
               .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.Aciklama)
              .IsUnicode()
             .HasMaxLength(30);
        }


    }
}
