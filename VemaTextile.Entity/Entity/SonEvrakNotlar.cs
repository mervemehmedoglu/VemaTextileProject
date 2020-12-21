using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class SonEvrakNotlar
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        
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

        
    }
}