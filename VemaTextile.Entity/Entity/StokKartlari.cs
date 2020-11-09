using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class StokKartlari
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        public string MalKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string MalAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        public string MalAdi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim { get; set; }

        [Column(TypeName = "money")]
        public decimal KritikStok { get; set; }

        [Column(TypeName = "money")]
        public decimal AzamiStok { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string KartTuru { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TıpKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string GrupKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OzelKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string UreticiKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string UreticiUnvan { get; set; }

        public int IskontoOran { get; set; }
        public int KdvOran { get; set; }
        public int OtvOran { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod10 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod11 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod12 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod13 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod14 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama2 { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Barkod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Barkod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Barkod3 { get; set; }

        [Column(TypeName = "money")]
        public string SatisFiyati1 { get; set; }

        [Column(TypeName = "money")]
        public string SatisFiyati2 { get; set; }

        [Column(TypeName = "money")]
        public string SatisFiyati3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KDVDahiliHaric1{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KDVDahiliHaric2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KDVDahiliHaric3 { get; set; }

        [Column(TypeName = "money")]
        public string DovizSatisFiyati1 { get; set; }

        [Column(TypeName = "money")]
        public string DovizSatisFiyati2 { get; set; }

        [Column(TypeName = "money")]
        public string DovizSatisFiyati3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim2{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Birim3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Birim2lslec { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Birim3lslec { get; set; }

        [Column(TypeName = "money")]
        public decimal Katsayi2 { get; set; }

        [Column(TypeName = "money")]
        public decimal Katsayi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ParaBirimi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ParaBirimi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ParaBirimi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        public DateTime KayitSaati { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        public DateTime DegisiklikSaati { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal SatisFiyati4 { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizSatisFiyati4 { get; set; }

        [Column(TypeName = "money")]
        public decimal AlimFiyati1 { get; set; }

        [Column(TypeName = "money")]
        public decimal AlimFiyati2 { get; set; }

        [Column(TypeName = "money")]
        public decimal AlimFiyati3 { get; set; }

        [Column(TypeName = "money")]
        public decimal AlimFiyati4 { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizAlimFiyati1 { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizAlimFiyati2 { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizAlimFiyati3 { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizAlimFiyati4 { get; set; }
    }
}