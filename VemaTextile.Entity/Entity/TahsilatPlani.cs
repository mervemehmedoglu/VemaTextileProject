using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TahsilatPlani
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

      

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdemeTipi { get; set; }

        
        [Required]
        public DateTime OdemeTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string OdemeDurumu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }


        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Column(TypeName = "decimal")]
        public decimal IDOdeme { get; set; }

       

    }
}