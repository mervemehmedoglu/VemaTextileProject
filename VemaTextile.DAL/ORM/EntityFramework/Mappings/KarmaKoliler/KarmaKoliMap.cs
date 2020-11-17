using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.KarmaKoliler
{
    public class KarmaKoliMap : EntityTypeConfiguration<KarmaKoli>
    {
        public KarmaKoliMap()
        {
            ToTable("KarmaKoliTablosu");

            HasKey(x => x.ID);

            Property(u => u.MamulMalKodu)
                .HasMaxLength(20)
                .IsUnicode();



            Property(u => u.MamulMalAdi)
                .HasMaxLength(50)
                .IsUnicode();


            Property(u => u.HammaddeMalKodu)
                .HasMaxLength(20)
                .IsUnicode();


            Property(u => u.HammaddeMalAdi)
                .HasMaxLength(50)
                .IsUnicode();


            Property(u => u.MamulYariMamul)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.Birim)
               .HasMaxLength(20)
               .IsUnicode();

            Property(u => u.EvrakNo)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.Birim1)
               .HasMaxLength(20)
               .IsUnicode();

            Property(u => u.MaliyetSekli)
               .HasMaxLength(50)
               .IsUnicode();


            Property(u => u.Depo)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.SeriNo)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.Kod1)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.Kod2)
               .HasMaxLength(20)
               .IsUnicode();


            Property(u => u.Kod3)
               .HasMaxLength(20)
               .IsUnicode();
        }
    }
}
