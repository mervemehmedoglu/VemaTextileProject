﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class KarmaKoli2
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MalKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Barkod { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }
        
        [Required]
        public DateTime Tarih { get; set; }
        public DateTime SevkTarihi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string IrsaliyeNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string SiparisNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IslemTipi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string IslemTuru { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MamulMalKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MamulMalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim1 { get; set; }

        [Column(TypeName = "money")]
        public decimal BirimMiktar { get; set; }

        [Column(TypeName = "money")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "money")]
        public decimal SevkMiktar { get; set; }

        [Column(TypeName = "money")]
        public decimal OranIskonto3 { get; set; }

        [Column(TypeName = "money")]
        public decimal BirimTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizBirimFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Irsfat { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { get; set; }

        [Column(TypeName = "money")]
        public decimal KDVOran { get; set; }
        
        [Column(TypeName = "money")]
        public decimal KDVTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KDVDahilHaric { get; set; }

        [Column(TypeName = "money")]
        public decimal OTVOran { get; set; }

        [Column(TypeName = "money")]
        public decimal OTVTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal OranIskonto { get; set; }

        [Column(TypeName = "money")]
        public decimal TutarIskonto { get; set; }

        [Column(TypeName = "money")]
        public decimal MasrafTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal OranIskonto2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Depo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SeriNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDSiparis { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod5 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDMailKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}