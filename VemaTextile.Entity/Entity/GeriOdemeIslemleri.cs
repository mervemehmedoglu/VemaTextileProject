using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class GeriOdemeIslemleri
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string BankaHesapKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TahsilatTipi { get; set; }

        [Key]
        [Required]
        public DateTime VadeTarihi { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal HizmetKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PuanKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal VadeKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal DigerKomisyon { get; set; }
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Row_ID { get; set; }




    }
}