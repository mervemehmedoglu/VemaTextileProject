using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Tahsilat
{
    public class TahsilatPlaniMap : EntityTypeConfiguration<TahsilatPlani>
    {
        public TahsilatPlaniMap()
        {
            ToTable("TahsilatPlaniTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapAdi)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.EvrakNo)
               .IsUnicode()
              .HasMaxLength(8);

            Property(u => u.Seri)
              .IsUnicode()
             .HasMaxLength(2);

            Property(u => u.OdemeTipi)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.OdemeDurumu)
             .IsUnicode()
            .HasMaxLength(10);

            Property(u => u.Aciklama)
             .IsUnicode()
            .HasMaxLength(50);

            Property(u => u.Kod1)
             .IsUnicode()
            .HasMaxLength(20);

            Property(u => u.Kod2)
            .IsUnicode()
           .HasMaxLength(20);

            Property(u => u.Kod3)
            .IsUnicode()
           .HasMaxLength(20);
        }


    }
}
