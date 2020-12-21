using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VemaTextile.Entity.Entity
{
    public class TaahhutKesifOzeti
    {
        [Key]
        public int ID { get; set; }
        public int IDCHKKodu { get; set; }

        
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
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
        [StringLength(11)]
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

        [Column(TypeName = "decimal")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Pesinat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal TaksitSayisi { get; set; }

        [Column(TypeName = "decimal")]
        public decimal FaizOrani { get; set; }

        [Column(TypeName = "decimal")]
        public decimal TaksitTutari { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ToplamTutar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Tip { get; set; }

        [Column(TypeName = "decimal")]
        public decimal T { get; set; }        //SMALLİNT YAPILACAK

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        
        [Column(TypeName = "decimal")]
        public decimal Miktar { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Fiyat { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ProjeMaliyeti { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Iscilik { get; set; }

        [Column(TypeName = "decimal")]
        public decimal VadeFarki { get; set; }

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

       
    }
}