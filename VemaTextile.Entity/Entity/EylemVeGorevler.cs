using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class EylemVeGorevler
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ChkKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string ChkAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string EylemGorev { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string EylemGorevTipi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string  TamamlanmaDurumu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string IlgiliKisi { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime Tarih { get; set; }
        public DateTime GorevTamamlamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "ntext")]
        public string Aciklama { get; set; }

    }
}