using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class SilinenKayitlar
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

       
    }
}