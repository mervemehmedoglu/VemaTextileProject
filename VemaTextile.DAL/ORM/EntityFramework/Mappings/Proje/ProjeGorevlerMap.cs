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
    public class ProjeGorevlerMap : EntityTypeConfiguration<ProjeGorevler>
    {
        public ProjeGorevlerMap()
        {
            HasKey(x => x.ID);

            Property(u => u.CHKKodu)
                .HasMaxLength(20)
                .IsUnicode();

            Property(u => u.EvrakNo)
                .HasMaxLength(8)
                .IsUnicode()
                .IsRequired();

            Property(u => u.TaskName)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.TaskStartTime)
                .IsRequired();

            Property(u => u.TaskFinishTime)
                .IsRequired();

            Property(u => u.BaslangicPlanTarihi)
                .IsRequired();

            Property(u => u.BitisPlanTarihi)
                .IsRequired();

            Property(u => u.Usta)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Planlama)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.TaskDuration)
                .HasMaxLength(5)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Onculler)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.OnculTask)
                .HasMaxLength(500)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Kullanan)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Kullanan2)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Durum)
                .HasMaxLength(20)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Okundu)
                .HasMaxLength(1)
                .IsUnicode()
                .IsRequired();

            Property(u => u.CHKAdi)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(u => u.Onem)
                .HasMaxLength(10)
                .IsUnicode()
                .IsRequired();
        }
    }
}
