using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VemaTextile.Models.Class
{
    public class TaahhutKesifOzeti
    {

        [Key]
        [Required]
        public DateTime Tarih { get; set; }


        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string CHKKodu { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi2 { get; set; }

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
        [StringLength(15)]
        public string Telefon { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(15)]
        public string Telefon2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TcKimlikNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KesifAlan { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KesfeGiden { get; set; }

        public DateTime KesifTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Referans { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Netice { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string AnlasmaYapildi { get; set; }     //smallint bakılcak bi buraya

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Notlar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Pesinat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaksitSayisi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FaizOrani { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaksitTutari { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamTutar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tip { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal T { get; set; }        //SMALLİNT YAPILACAK

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fiyat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProjeMaliyeti { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Iscilik { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal VadeFarki { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KdvOtomatik { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Kdv { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamMaliyet { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Kar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal KarYuzdesi { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}