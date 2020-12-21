using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class UretimRecetesi
    {
        [Key]
        public int ID { get; set; }

        public int IDMamulMalKodu { get; set; }
        public int IDHammaddeMalKodu { get; set; }
        public int IDFireliMalKodu { get; set; }

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

        [Column(TypeName = "decimal")]
        public decimal BirimMiktar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim1 { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Miktar { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod5 { get; set; }

        public int FireOrani { get; set; }

        [Column(TypeName = "money")]
        public decimal FireMiktari { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string FireliMalKodu { get; set; }

       
    }
}