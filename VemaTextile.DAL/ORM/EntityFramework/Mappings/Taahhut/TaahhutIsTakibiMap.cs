using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;


namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.Taahhut
{
    public class TaahhutIsTakibiMap : EntityTypeConfiguration<TaahhutIsTakibi>
    {
        public TaahhutIsTakibiMap()
        {
            ToTable("TaahhutIsTakibiTablosu");
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.EvrakNo)
                .HasMaxLength(8)
                .IsUnicode();

            Property(u => u.Seri)
                .HasMaxLength(2)
                .IsUnicode();

            Property(u => u.HesapAdi)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.TesisatAdres1)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.TesisatAdres2)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.TesisatAdres3)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Telefon1)
              .HasMaxLength(20)
              .IsUnicode();

            Property(u => u.Telefon2)
              .HasMaxLength(20)
              .IsUnicode();

            Property(u => u.Telefon3)
              .HasMaxLength(20)
              .IsUnicode();

            Property(u => u.TesisatNo)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.YapilanIs)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.AgizSayisi)
              .HasMaxLength(3)
              .IsUnicode();

            Property(u => u.Usta)
              .HasMaxLength(20)
              .IsUnicode();

            Property(u => u.AnlasmaYapildi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.IseBaslandi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.ProjeCizildi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.IsBitirildi)
              .HasMaxLength(1)
              .IsUnicode();

              Property(u => u.TesisatAdres1)
                .HasMaxLength(50)
                .IsUnicode();

            Property(u => u.ProjeOnaylandi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.SozlesmeYapildi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.IsBitirildi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.ProjeCizildi)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.Randevu1)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.Randevu2)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.Randevu3)
              .HasMaxLength(1)
              .IsUnicode();

            Property(u => u.Eksikler1)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Eksikler2)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Eksikler3)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.TeklifNo)
              .HasMaxLength(8)
              .IsUnicode();

            Property(u => u.FaturaNo)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Notlar1)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Notlar2)
              .HasMaxLength(50)
              .IsUnicode();

            Property(u => u.Notlar3)
              .HasMaxLength(50)
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

            Property(u => u.Kaydeden)
              .HasMaxLength(20)
              .IsUnicode();

            Property(u => u.Degistiren)
              .HasMaxLength(20)
              .IsUnicode();



        }
    }
}
