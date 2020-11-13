using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutTeklifUstaBilgileri
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UstaKodu{ get; set; }

        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string UstaAdi { get; set; }

        [Column(TypeName = "ntext")]
        public string İscilikTipiT { get; set; }

        [Column(TypeName = "ntext")]
        public string İscilikTipiTAciklama { get; set; }

        [Column(TypeName = "ntext")]
        public string İscilikTipiAciklama { get; set; }

        [Column(TypeName = "ntext")]
        public string İscilikTipiMiktar { get; set; }

        [Column(TypeName = "ntext")]
        public string İscilikTipiFiyat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal İscilik { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string IDUstaKodu { get; set; }

       
    }
}