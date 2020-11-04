using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class ProjeGorevAciklama
    {
        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string ID { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string GorevID { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan { get; set; }
       
        public DateTime Tarih { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }


    }
}