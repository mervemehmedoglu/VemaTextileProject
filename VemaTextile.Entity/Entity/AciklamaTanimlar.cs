using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class AciklamaTanimlar
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Parametre1 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Parametre2 { get; set; }

        [Column(TypeName = "text")]
        public String Aciklama { get; set; }
    }
}