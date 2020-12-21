﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class MuhasebeIslemleri
    {

        [Key]
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        public DateTime Tarih { get; set; }

       
        [Column(TypeName = "money")]
        public decimal FisNo { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal MaddeNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string VadeTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(6)]
        public string IslemTuru { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string FisTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MasrafMerkeziKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MasrafMerkeziAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string FisKodu { get; set; }

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
        [StringLength(50)]
        public string EvrakTipi { get; set; }

        [Column(TypeName = "nvarchar")]                //Evrak Length bak
        [StringLength(17)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string EvrakTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string EvrakHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string EvrakHesapAdi { get; set; }

        [Column(TypeName = "money")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "money")]
        public decimal BorcTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal AlacakTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizBorcTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizAlacakTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Ay { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

    }
}