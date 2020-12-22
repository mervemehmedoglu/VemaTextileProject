using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutTeklifUstaBilgileriMap : EntityTypeConfiguration<TaahhutTeklifUstaBilgileri>
    {
        public TaahhutTeklifUstaBilgileriMap()
        {
            ToTable("TaahhutTeklifUstaBilgileriTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.UstaKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.UstaAdi)
               .IsUnicode()
              .HasMaxLength(50);

        }


    }
}
