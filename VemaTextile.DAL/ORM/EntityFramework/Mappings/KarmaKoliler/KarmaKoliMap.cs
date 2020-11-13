using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Karma_Koliler
{
    public class KarmaKoliMap : EntityTypeConfiguration<KarmaKoli>
    {
        public KarmaKoliMap()
        {
            ToTable("KarmaKoliTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .HasColumnName("ID");


            Property(u => u.MamulMalKodu)
                .HasMaxLength(20)
                .HasColumnName("MamulMalKodu");


            Property(u => u.MamulMalAdi)
                .HasMaxLength(50)
                .HasColumnName("MamulMalAdi");

            Property(u => u.HammaddeMalKodu)
                .HasMaxLength(20)
                .HasColumnName("HammaddeMalKodu");

            Property(u => u.HammaddeMalAdi)
                .HasMaxLength(50)
                .HasColumnName("HammaddeMalAdi");

            Property(u => u.MamulYariMamul)
               .HasMaxLength(20)
               .HasColumnName("MamulYariMamul");

            Property(u => u.Birim)
               .HasMaxLength(20)
               .HasColumnName("Birim");

            Property(u => u.EvrakNo)
               .HasMaxLength(20)
               .HasColumnName("EvrakNo");

            Property(u => u.Birim1)
               .HasMaxLength(20)
               .HasColumnName("Birim1");

            Property(u => u.Miktar)
               .HasColumnName("Miktar");

            Property(u => u.MaliyetSekli)
               .HasMaxLength(50)
               .HasColumnName("MaliyetSekli");

            Property(u => u.Depo)
               .HasMaxLength(20)
               .HasColumnName("Depo");

            Property(u => u.SeriNo)
               .HasMaxLength(20)
               .HasColumnName("SeriNo");

            Property(u => u.Kod1)
               .HasMaxLength(20)
               .HasColumnName("Kod1");

            Property(u => u.Kod2)
               .HasMaxLength(20)
               .HasColumnName("Kod2");

            Property(u => u.Kod3)
               .HasMaxLength(20)
               .HasColumnName("Kod3");

            Property(u => u.BirimFiyat)
               .HasColumnName("BirimFiyat");

            Property(u => u.BirimTutar)
               .HasColumnName("BirimTutar");

            Property(u => u.Fiyat)
                .HasColumnName("Fiyat");

            Property(u => u.Tutar)
                .HasColumnName("Tutar");

        }
    }
}
