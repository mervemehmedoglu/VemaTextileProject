using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class MuhasebeIsletmeKodlari
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KdvDahilHaric { get; set; }

        public int KdvOran { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DBTutar { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DBKdv { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DBMiktar { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DSTutar { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DSKdv { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal DSMiktar { get; set; }

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
        [StringLength(10)]
        public string Kaydeden { get; set; }

        
        public DateTime KayitTarihi { get; set; }
        public DateTime KayitSaati { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }
        public DateTime DegisiklikSaati { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}