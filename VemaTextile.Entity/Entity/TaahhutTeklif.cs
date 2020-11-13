using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VemaTextile.Models.Class
{
    public class TaahhutTeklif
    {
        [Key]
        public int ID { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string Seri { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdresi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdresi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon3 { get; set; }

        [Column(TypeName = "money")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal PesinatTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal TaksitSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal VadeFarkiOrani { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar1 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar2 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar3 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar4 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar5 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar6 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar7 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar8 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar9 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar10 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar11 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar12 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar13 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar14 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar15 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar16 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar17 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar18 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar19 { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifTutar20 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Marka1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Marka2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Marka3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Marka4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tip1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tip2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tip3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Tip4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Model1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Model2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Model3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Model4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kapasite1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kapasite2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kapasite3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kapasite4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Garanti1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Garanti2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Garanti3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Garanti4 { get; set; }

        [Column(TypeName = "money")]
        public decimal EuroFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal EuroFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal EuroFiyat3 { get; set; }

        [Column(TypeName = "money")]
        public decimal EuroFiyat4 { get; set; }

        [Column(TypeName = "money")]
        public decimal TLFiyat1 { get; set; }

        [Column(TypeName = "money")]
        public decimal TLFiyat2 { get; set; }

        [Column(TypeName = "money")]
        public decimal TLFiyat3 { get; set; }

        [Column(TypeName = "money")]
        public decimal TLFiyat4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        

    }
}