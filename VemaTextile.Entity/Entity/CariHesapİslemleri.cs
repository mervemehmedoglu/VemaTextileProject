using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class CariHesapİslemleri
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string EvrakNo{ get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string  Seri { get; set; }
       
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }
       
        public DateTime Tarih { get; set; }
        
        [Column(TypeName = "money")]
        public decimal OpsiyonGunu{ get; set; }
        
        public DateTime VadeTarihi { get; set; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(6)]
        public string IslemTuru { get; set; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(80)]
        public string KaynakEvrakTipi { get; set; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        public string HesapKodu { get; set; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        public string HesapAdi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { get; set; }
       
        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public int DovizCinsi { get; set; }
        
        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }
        
        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }
        
        [Column(TypeName = "money")]
        public decimal KDVTutar{ get; set; }
        
        [Column(TypeName = "money")]
        public decimal OTVTutar{ get; set; }
       
        [Column(TypeName = "money")]
        public decimal IskontoTutar{ get; set; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string PesinVadeli{ get; set; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KarsiHesapKOdu{ get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KarsiHesapAdi{ get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(3)]
        public string BakiyeEtkisi{ get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod1{ get; set; }
       
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod2{ get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod3{ get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod4{ get; set; }
       
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Kod5{ get; set; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama{ get; set; }
       
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden{ get; set; }
        
        public DateTime KayitTarihi{ get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren{ get; set; }
        public DateTime DegisiklikTarihi{ get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDHesapKodu{ get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID{ get; set; }

       


    }
}