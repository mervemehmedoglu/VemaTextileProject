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
    public class GeriOdemePlaniMap : EntityTypeConfiguration<GeriOdemePlani>
    {
        public GeriOdemePlaniMap()
        {
            ToTable("Geri Odeme Plani Tablosu");


            Property(u => u.HesapKodu)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Hesap Kodu");

            Property(u => u.HesapAdi)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnName("Hesap Adi");

            Property(u => u.Aciklama)
               .IsOptional()
               .HasMaxLength(50)
               .HasColumnName("Aciklama");

            Property(u => u.Tip)
               .IsOptional()
               .HasMaxLength(50)
               .HasColumnName("Tip");

            Property(u => u.Ay)
               .IsOptional()
               .HasColumnName("Ay");

            Property(u => u.Gun)
               .IsOptional()
               .HasColumnName("Gun");

            Property(u => u.SabitGun)
               .IsOptional()
               .HasColumnName("Sabit Gun");

            Property(u => u.HizmetKomisyonu)
               .IsOptional()
               .HasColumnName("Hizmet Komisyonu");

            Property(u => u.PuanKomisyonu)
               .IsOptional()
               .HasColumnName("Puan Komisyonu");

            Property(u => u.VadeKomisyonu)
               .IsOptional()
               .HasColumnName("Vade Komisyonu");

            Property(u => u.DigerKomisyon)
               .IsOptional()
               .HasColumnName("Diger Komisyonu");

           

        }
    }
}
