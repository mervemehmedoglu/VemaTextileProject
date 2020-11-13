using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class ProjeTakibi
    {
        [Key]
        public int ID { get; set; }

        public int IDCHKKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CHKKodu { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        
        

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Adres1 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Adres2 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Adres3 { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon1 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger1 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger2 { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger3 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DigerTutar1 { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DigerTutar2 { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal DigerTutar3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Teklif { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger1Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger2Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger3Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger4Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger5Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger6Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger7Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger8Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger9Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Diger10Aciklama { get; set; }

        [Column(TypeName = "decimal")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "decimal")]
        public decimal NakitTahsilat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Senetler { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Cekler { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ProjeMaliyeti { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Iadeler { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Iscilik { get; set; }

        [Column(TypeName = "decimal")]
        public decimal IscilikDiger { get; set; }

        [Column(TypeName = "decimal")]
        public decimal IscilikTedarik { get; set; }

        [Column(TypeName = "decimal")]
        public decimal SenetVadeFarki { get; set; }

        [Column(TypeName = "decimal")]
        public decimal CekVadeFarki { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KdvOtomatik { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Kdv { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ToplamMaliyet { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Kar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal KarYuzdesi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string AnlasmaTutariEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string PesinatEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string SenetlerEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string CeklerEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string IadelerEvrakNo { get; set; }

        [Column(TypeName = "decimal")]
        public decimal EkMaliyet { get; set; }

        [Column(TypeName = "decimal")]
        public decimal EkMaliyetYuzde { get; set; }

        [Column(TypeName = "decimal")]
        public decimal DevirAnlasmaTutari { get; set; }

        [Column(TypeName = "decimal")]
        public decimal DevirUrunMaliyeti { get; set; }

        
    }
}