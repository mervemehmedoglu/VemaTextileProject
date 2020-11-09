using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class AlinanSenetler
    {
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal EvrakNO { set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { set; get; }
       
        [Column(TypeName = "decimal(18,0)")]
        public decimal IDNo { set; get; }
       
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Borclu { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string BorcluUnvan { set; get; }

        public DateTime AlimTarihi{ set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SenediVeren { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SenediVerenUnvan { set; get; }

        [Column(TypeName = "money")]
        public decimal Tutar { set; get; }

        [Column(TypeName = "money")]
        public decimal TahsilMasrafi { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SenetTipi { set; get; }

        [Key]
        [Required]
        public DateTime VadeTarihi { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sehir { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string DovizTL { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { set; get; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { set; get; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Banka { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sube { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string BankaHesapNo { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SenetNo { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TahsileCikilanBanka { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TahsileCikilanBankaUnvan { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string İslemTipi { set; get; }

        public DateTime Tarih { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string SonPozisyon { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(8)]
        public string BordroNo { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string BordroSeri { set; get; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal BordroIdNo { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal IDSenet { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { set; get; }

        public DateTime KayitTarihi { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { set; get; }

        public DateTime DegisiklikTarihi { set; get; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { set; get; }







    }
}