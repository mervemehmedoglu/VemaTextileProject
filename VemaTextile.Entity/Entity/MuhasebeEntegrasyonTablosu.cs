using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class MuhasebeEntegrasyonTablosu
    {
        [Column(TypeName = "decimal(18,0)")]
        public decimal RowNumber { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string KaynakEvrakTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string SatirTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Tanim1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Tanim2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Tanim3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Tanim4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1000)]
        public string TanimSQL { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1000)]
        public string AciklamaSQL { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SonKaydeden { get; set; }
        
        public int LenTanim1 { get; set; }
        public int LenTanim2 { get; set; }
        public int LenTanim3 { get; set; }
        public int LenTanim4 { get; set; }
        public int LenAciklama1 { get; set; }
        public int LenAciklama2 { get; set; }
        public int LenAciklama3 { get; set; }
        public int LenAciklama4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string FisTipi { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}