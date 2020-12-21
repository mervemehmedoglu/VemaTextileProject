using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class ProjeKaynaklar
    {
        [Key]
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tıp { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        
       

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

        
        [Column(TypeName = "decimal")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Fiyat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Hakedis { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string GorevAdi { get; set; }

        
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

       



    }
}