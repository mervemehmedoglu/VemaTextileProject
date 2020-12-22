using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;



namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Proje
{
    public class ProjeKategorilerMap : EntityTypeConfiguration<ProjeKategoriler>
    {
        public ProjeKategorilerMap()
        {
            ToTable("ProjeKategorilerTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.ProjectKey)
                .IsUnicode()
                .HasMaxLength(50);


            Property(u => u.TaskName)
               .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.TaskDuration)
              .IsUnicode()
             .HasMaxLength(5);

            Property(u => u.Onculler)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.TaskPercentComplete)
              .IsUnicode()
             .HasMaxLength(5);

            Property(u => u.Constraint)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.MilesStone)
              .IsUnicode()
             .HasMaxLength(50);

            Property(u => u.OnculTask)
              .IsUnicode()
             .HasMaxLength(400);

            Property(u => u.Kullanan)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.Gun2)
              .IsUnicode()
             .HasMaxLength(5);

            Property(u => u.Gun3)
              .IsUnicode()
             .HasMaxLength(5);

            Property(u => u.ConstraintDateTime)
              .IsUnicode()
             .HasMaxLength(20);

            Property(u => u.SonTarih)
              .IsUnicode()
             .HasMaxLength(20);

        }


    }
}
