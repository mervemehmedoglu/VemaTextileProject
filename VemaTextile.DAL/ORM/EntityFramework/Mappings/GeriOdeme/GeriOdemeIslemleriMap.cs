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


            Property(u => u.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("HesapKodu");

            Property(u => u.BankaHesapKodu)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("BankaHesapKodu");

            Property(u => u.EvrakNo)
               .IsRequired()
               .HasMaxLength(8)
               .HasColumnName("EvrakNo");

            Property(u => u.TahsilatTipi)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("TahsilatTipi");

            Property(u => u.VadeTarihi)
               .IsRequired()
               .HasColumnName("VadeTarihi ");

            Property(u => u.Tutar)
               .HasColumnName("Tutar");

            Property(u => u.HizmetKomisyonu)
               .HasColumnName("HizmetKomisyonu ");

            Property(u => u.PuanKomisyonu)
               .HasColumnName("PuanKomisyonu");

            Property(u => u.VadeKomisyonu)
               .HasColumnName("VadeKomisyonu ");

            Property(u => u.DigerKomisyon)
               .HasColumnName("DigerKomisyon ");

            

        }
    }
}
