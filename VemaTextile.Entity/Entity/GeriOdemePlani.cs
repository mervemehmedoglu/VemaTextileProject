using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class GeriOdemePlani
    {
        [Key]
        public int ID { get; set; }

        
        public int IDHesapKodu { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

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

        [Column(TypeName = "decimal")]
        public decimal Ay { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Gun { get; set; }
        [Column(TypeName = "decimal")]
        public decimal SabitGun { get; set; }
        [Column(TypeName = "decimal")]
        public decimal HizmetKomisyonu { get; set; }
        [Column(TypeName = "decimal")]
        public decimal PuanKomisyonu { get; set; }
        [Column(TypeName = "decimal")]
        public decimal VadeKomisyonu { get; set; }
        [Column(TypeName = "decimal")]
        public decimal DigerKomisyon { get; set; }
        

    }
}