using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutPrimTakibi
    {
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
        [StringLength(10)]
        public string FaturaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string FaturaNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Unvan { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CihazMarka { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CihazTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CihazModel { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CihazSeriNo { get; set; }

        [Column(TypeName = "money")]
        public decimal CihazTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string CalistirilmaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string PrimAlinmaDurumu { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }



    }
}