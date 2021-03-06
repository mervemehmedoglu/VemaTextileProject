﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class VerilenSenetler
    {
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal EvrakNo { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }



        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string BankaCH { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string BankaCHUnvan { get; set; }

        public DateTime VerilisTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string VerildigiYerUnvan { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "money")]
        public decimal TahsilMasrafi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SenetTipi { get; set; }

        [Key]
        [Required]
        public DateTime VadeTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sehir { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string BankaHesapNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SenetNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string IslemTipi { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string SonPozisyon { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string BordroNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string BordroSeri { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal BordroIdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal IDSenet { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}