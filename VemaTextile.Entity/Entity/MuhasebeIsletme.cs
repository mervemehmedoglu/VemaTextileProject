using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class MuhasebeIsletme
    {
        [Key]
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }
        public int IDIsletmeKodu { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string IsletmeKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string BordroNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string BordroSeri { get; set; }

        [Column(TypeName = "decimal")]
        public decimal BordroIdNo { get; set; }

        public DateTime Tarih { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal EvrakNo { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string FaturaEvrakNo { get; set; }

        [Required]
        public DateTime VadeTarih { get; set; }

        

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Miktar { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal HizmetTutar { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Tutar { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KdvDahilHaric { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal KdvOran { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Kdv { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Toplam { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Iade { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string IslemTipi { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

    }
}