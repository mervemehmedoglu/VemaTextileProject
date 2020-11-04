using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class KarmaKoli
    {
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MamulMalKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MamulMalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HammaddeMalKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HammaddeMalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MamulYariMamul { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim1 { get; set; }

        [Column(TypeName = "money")]
        public string Miktar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string MaliyetSekli { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Depo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SeriNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Column(TypeName = "money")]
        public string BirimFiyat { get; set; }

        [Column(TypeName = "money")]
        public string BirimTutar { get; set; }

        [Column(TypeName = "money")]
        public string Fİyat { get; set; }

        [Column(TypeName = "money")]
        public string Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDMalKodu { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}