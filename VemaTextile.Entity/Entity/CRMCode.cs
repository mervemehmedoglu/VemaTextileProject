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
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Aciklama{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string Aciklama2 { get; set; }

        public int KodTipi { get; set; }

        [Column(TypeName = "decimal")]
        public decimal SiraNo { get; set; }

        
    }
}