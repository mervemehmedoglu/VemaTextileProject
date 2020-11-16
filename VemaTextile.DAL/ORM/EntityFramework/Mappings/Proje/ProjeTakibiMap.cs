using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Proje
{
    public class ProjeTakibiMap : EntityTypeConfiguration<ProjeTakibi>
    {
        public ProjeTakibiMap()
        {
            HasKey(x => x.ID);

            Property(u => u.CHKKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tarih)
               .IsRequired();

            Property(u => u.EvrakNo)
               .HasMaxLength(8)
               .IsRequired()
               .IsUnicode();

            Property(u => u.Seri)
               .HasMaxLength(2)
               .IsRequired()
               .IsUnicode();

            Property(u => u.CHKAdi)
               .HasMaxLength(50)
               .IsRequired()
               .IsUnicode();

            Property(u => u.Adres1)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.Adres2)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.Adres3)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.Telefon1)
               .HasMaxLength(20)
               .IsUnicode();

            Property(u => u.Telefon2)
               .HasMaxLength(20)
               .IsUnicode();

            Property(u => u.Diger1)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Diger2)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Diger3)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Teklif)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Diger1Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger2Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger3Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger4Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger5Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger6Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger7Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger8Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger9Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.Diger10Aciklama)
             .HasMaxLength(20)
             .IsUnicode();

            Property(u => u.KdvOtomatik)
             .HasMaxLength(5)
             .IsUnicode();

            Property(u => u.AnlasmaTutariEvrakNo)
             .HasMaxLength(8)
             .IsUnicode();

            Property(u => u.PesinatEvrakNo)
             .HasMaxLength(8)
             .IsUnicode();

            Property(u => u.SenetlerEvrakNo)
             .HasMaxLength(8)
             .IsUnicode();

            Property(u => u.CeklerEvrakNo)
             .HasMaxLength(8)
             .IsUnicode();

            Property(u => u.IadelerEvrakNo)
             .HasMaxLength(8)
             .IsUnicode();
        }
    }
}
