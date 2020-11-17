﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using VemaTextile.Entity.Entity;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Mappings.KarmaKoliler
{
    public class KarmaKoli2Map : EntityTypeConfiguration<KarmaKoli2>
    {
        public KarmaKoli2Map()
        {
            ToTable("KarmaKoli2Tablosu");

            HasKey(x => x.ID);
            

            Property(u => u.MalKodu)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.MalAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Barkod)
                .IsUnicode()
                .HasMaxLength(40);

            Property(u => u.Aciklama)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.EvrakNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.Seri)
                .IsUnicode()
                .HasMaxLength(2);

            Property(u => u.IrsaliyeNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.SiparisNo)
                .IsUnicode()
                .HasMaxLength(8);

            Property(u => u.IslemTipi)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.IslemTuru)
                .IsUnicode()
                .HasMaxLength(2);

            Property(u => u.MamulMalAdi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Birim)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Birim1)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.DovizTL)
                .IsUnicode()
                .HasMaxLength(5);

            Property(u => u.DovizCinsi)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Irsfat)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.KaynakEvrakTipi)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.KDVDahilHaric)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Depo)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.SeriNo)
                .IsUnicode()
                .HasMaxLength(50);

            Property(u => u.Kod1)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod2)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod3)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod4)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kod5)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Kaydeden)
                .IsUnicode()
                .HasMaxLength(20);

            Property(u => u.Degistiren)
                .IsUnicode()
                .HasMaxLength(20);

        }
    }
}
