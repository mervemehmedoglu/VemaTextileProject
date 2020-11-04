using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class OdemePlani
    {
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDHesapKodu { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }


        
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdemeTipi { get; set; }

        [Key]
        [Required]
        public DateTime OdemeTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string OdemeDurumu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal IdOdeme { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }

    }
}