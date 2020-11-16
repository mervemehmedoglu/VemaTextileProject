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
    public class ProjeKaynaklarMap : EntityTypeConfiguration<ProjeKaynaklar>
    {
        public ProjeKaynaklarMap()
        {
            HasKey(x => x.ID);

            Property(u => u.HesapKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Tıp)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.Aciklama)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.HesapAdi)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.EvrakNo)
                .HasMaxLength(8)
                .IsUnicode()
                .IsRequired();

            Property(u => u.ProjeNo)
                .HasMaxLength(8)
                .IsUnicode()
                .IsRequired();

            Property(u => u.GorevAdi)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.DevirNormal)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Kaydeden)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Degistiren)
                .HasMaxLength(20)
                .IsUnicode();
        }
    }
}
