using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TeklifAciklama
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Ok { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public string Tutar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal SiraNo { get; set; }

        
    }
}