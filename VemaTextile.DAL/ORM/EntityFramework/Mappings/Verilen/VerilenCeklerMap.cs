using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Verilen
{
    public class VerilenCeklerMap : EntityTypeConfiguration<VerilenCekler>
    {
        public VerilenCeklerMap()
        {
            ToTable("VerilenCeklerTablosu");

            HasKey(x => x.ID);
            Property(x => x.ID)
                .IsRequired();


            Property(u => u.HesapKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.HesapAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Seri)
              .IsUnicode()
              .HasMaxLength(2);

            Property(u => u.BankaCH)
              .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.BankaCHUnvan)
              .IsUnicode()
              .HasMaxLength(200);

            Property(u => u.VerildigiYerUnvan)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.CekTipi)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Sehir)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kod1)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kod2)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kod3)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kod4)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kod5)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.DovizTL)
              .IsUnicode()
              .HasMaxLength(5);

            Property(u => u.DovizCinsi)
              .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.BankaHesapNo)
              .IsUnicode()
              .HasMaxLength(20);

            Property(u => u.IslemTipi)
              .IsUnicode()
              .HasMaxLength(40);

            Property(u => u.SonPozisyon)
              .IsUnicode()
              .HasMaxLength(40);

            Property(u => u.BordroNo)
              .IsUnicode()
              .HasMaxLength(8);

            Property(u => u.BordroSeri)
              .IsUnicode()
              .HasMaxLength(2);

            Property(u => u.Aciklama)
              .IsUnicode()
              .HasMaxLength(50);

            Property(u => u.Kaydeden)
              .IsUnicode()
              .HasMaxLength(10);

            Property(u => u.Degistiren)
              .IsUnicode()
              .HasMaxLength(10);
        }
    }
}
