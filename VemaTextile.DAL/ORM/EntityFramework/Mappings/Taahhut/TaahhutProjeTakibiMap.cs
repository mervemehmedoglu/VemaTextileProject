using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutProjeTakibiMap : EntityTypeConfiguration<TaahhutProjeTakibi>
    {
        public TaahhutProjeTakibiMap()
        {
            HasKey(x => x.ID);

            Property(u => u.CHKKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(2)
                .IsUnicode();

            Property(u => u.CHKAdi)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.CHKAdi2)
               .HasMaxLength(50)
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

            Property(u => u.Telefon)
               .HasMaxLength(15)
               .IsUnicode();

            Property(u => u.Telefon2)
               .HasMaxLength(15)
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

            Property(u => u.Randevu1Eksik)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.Randevu2Eksik)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.Randevu3Eksik)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.SeriNo)
               .HasMaxLength(50)
               .IsUnicode();

            Property(u => u.AnlasmaYapildi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.IseBaslandi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.IsBitirildi)
               .HasMaxLength(5)
               .IsUnicode();


            Property(u => u.ProjeCizildi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.ProjeVerildi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.ProjeOnaylandi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.SozlesmeYapildi)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Randevu1)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Randevu2)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.Randevu3)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.KontrolYapildi)
               .HasMaxLength(5)
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

            Property(u => u.Diger1Aciklama)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.Diger2Aciklama)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.Diger3Aciklama)
               .HasMaxLength(30)
               .IsUnicode();

            Property(u => u.KdvOtomatik)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.AnlasmaTutariEvrakNo)
               .HasMaxLength(8)
               .IsUnicode();

            Property(u => u.PesinatEvrakNo)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.SenetlerEvrakNo)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.CeklerEvrakNo)
               .HasMaxLength(5)
               .IsUnicode();

            Property(u => u.IadelerEvrakNo)
               .HasMaxLength(5)
               .IsUnicode();
        }
    }
}
