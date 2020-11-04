using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class GeriOdemePlani
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string HesapKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Tip { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal Ay { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal Gun { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal SabitGun { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal HizmetKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal PuanKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal VadeKomisyonu { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal DigerKomisyon { get; set; }
        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }

    }
}