using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class ProjeKaynaklar
    {
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tıp { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string ProjeNo { get; set; }

        
        [Column(TypeName = "decimal(19,2)")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        public decimal Fiyat { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "decimal(19,2)")]
        public decimal Hakedis { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string GorevID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string GorevAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDHesapKodu { get; set; }

        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DevirNormal { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        

        public DateTime KayitTarihi { get; set; }
        public DateTime KayitSaati { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }
        public DateTime DegisiklikSaati { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }



    }
}