using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;
namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutUstaBilgileriMap : EntityTypeConfiguration<TaahhutUstaBilgileri>
    {
        public TaahhutUstaBilgileriMap()
        {
            ToTable("TaahhutUstaBilgileriTablosu");

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

            Property(u => u.Tıp)
              .IsUnicode()
             .HasMaxLength(10);


        }


    }
}
