using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.FaturaBilgi
{
    public class FaturaBilgileriMap : EntityTypeConfiguration<FaturaBilgileri>
    {
        public FaturaBilgileriMap()
        {
            ToTable("FaturaBilgiTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.CHKKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.CHKAdi)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.EvrakNo)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.Tıp)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(30);


            Property(u => u.DovizTL)
                .IsUnicode()
                .HasMaxLength(10);

            Property(u => u.DovizCinsi)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod1)
                .IsUnicode()
                .HasMaxLength(20);


            Property(u => u.Kod2)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod3)
              .IsUnicode()
              .HasMaxLength(20);



            Property(u => u.TeslimAdres1)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.TeslimAdres2)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.TeslimAdres3)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.Aciklama1)
              .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.Aciklama2)
                .IsUnicode()
              .HasMaxLength(50);


            Property(u => u.KDVHesaplama)
              .IsUnicode()
              .HasMaxLength(10);


            Property(u => u.KaynakEvrakTipi)
              .IsRequired()
              .HasMaxLength(50);

            
        }
    }
}
