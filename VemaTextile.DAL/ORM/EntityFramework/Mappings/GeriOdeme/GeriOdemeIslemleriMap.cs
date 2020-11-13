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
            ToTable("Geri Odeme Islemleri Tablosu");


            Property(u => u.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("Hesap Kodu");

            Property(u => u.BankaHesapKodu)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("Banka Hesap Kodu");

            Property(u => u.EvrakNo)
               .IsRequired()
               .HasMaxLength(8)
               .HasColumnName("Evrak No");

            Property(u => u.TahsilatTipi)
               .IsRequired()
               .HasMaxLength(20)
               .HasColumnName("Tahsilat Tipi");

            Property(u => u.VadeTarihi)
               .IsRequired()
               .HasColumnName("Vade Tarihi ");

            Property(u => u.Tutar)
               .HasColumnName("Tutar ");

            Property(u => u.HizmetKomisyonu)
               .HasColumnName("Hizmet Komisyonu ");

            Property(u => u.PuanKomisyonu)
               .HasColumnName("Puan Komisyonu");

            Property(u => u.VadeKomisyonu)
               .HasColumnName("Vade Komisyonu ");

            Property(u => u.DigerKomisyon)
               .HasColumnName("Diger Komisyon ");

            

        }
    }
}
