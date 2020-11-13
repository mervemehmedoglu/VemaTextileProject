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
    public class FaturaBilgiMap : EntityTypeConfiguration<FaturaBilgileri>
    {
        public FaturaBilgiMap()
        {
            ToTable("FaturaBilgi");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();

            Property(u => u.EvrakNo)
                .IsRequired();

            Property(u => u.CHKAdi)
                .IsOptional();

            Property(u => u.Tıp)
                .IsRequired()
                .HasMaxLength(30);


            Property(u => u.Tutar)
                .IsOptional();


            Property(u => u.Oran)
                .IsOptional();


            Property(u => u.DovizTL)
                .IsOptional()
                .HasMaxLength(10);


            Property(u => u.DovizCinsi)
                .IsOptional()
                .HasMaxLength(20);


            Property(u => u.DovizKuru)
                .IsOptional();


            Property(u => u.DovizTutar)
                .IsOptional();


            Property(u => u.Kod1)
                .IsOptional()
                .HasMaxLength(20);


            Property(u => u.Kod2)
                .IsOptional()
                .HasMaxLength(20);


            Property(u => u.Kod3)
              .IsOptional()
              .HasMaxLength(20);


            Property(u => u.Kod4)
              .IsOptional();


            Property(u => u.Kod5)
              .IsOptional();


            Property(u => u.TeslimAdres1)
              .IsOptional()
              .HasMaxLength(50);


            Property(u => u.TeslimAdres2)
              .IsOptional()
              .HasMaxLength(50);


            Property(u => u.TeslimAdres3)
              .IsOptional()
              .HasMaxLength(50);


            Property(u => u.Aciklama1)
              .IsOptional()
              .HasMaxLength(50);

            Property(u => u.Aciklama2)
              .IsOptional()
              .HasMaxLength(50);


            Property(u => u.KDVHesaplama)
              .IsOptional()
              .HasMaxLength(10);


            Property(u => u.KaynakEvrakTipi)
              .IsRequired()
              .HasMaxLength(50);
             

            
        }
    }
}
