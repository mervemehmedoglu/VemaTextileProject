using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class SonEvrakNotlar
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { get; set; }

        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string EvrakNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(4)]
        public string Seri { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}