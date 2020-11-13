using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.GeriOdeme
{
    public class GeriOdemeIslemleriMap : EntityTypeConfiguration<GeriOdemeIslemleri>
    {
        public GeriOdemeIslemleriMap()
        {
            ToTable("GeriOdemeIslemleriTablosu");

            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.BankaHesapKodu)
               .IsRequired()
               .HasMaxLength(20);

            Property(u => u.EvrakNo)
               .IsRequired()
               .HasMaxLength(8);

            Property(u => u.TahsilatTipi)
               .IsRequired()
               .HasMaxLength(20);


            Property(u => u.VadeTarihi)
               .IsRequired();


            

        }
    }
}
