using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class KOD
    {
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IslemKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tıp { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Aciklama { get; set; }
    }
}