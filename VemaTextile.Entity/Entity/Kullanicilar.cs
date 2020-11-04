using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class Kullanicilar
    {
        [Key]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public int KullaniciKodu { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KullaniciAdi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sifre { get; set; }
     
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }


    }
}