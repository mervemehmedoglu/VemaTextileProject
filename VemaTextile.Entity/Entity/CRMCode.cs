using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class CRMCode
    {
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Id { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal KategoriId { get; set; }
  
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Aciklama{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string Aciklama2 { get; set; }

        [Column(TypeName = "smallint")]
        public int KodTipi { get; set; }

        [Column(TypeName = "decimal(10,0)")]
        public decimal SiraNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}