using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VemaTextile.Models.Class
{
    public class CariHesapKartlari
    {
        [Key]
        [Required]
        public int HesapKodu { get; set; }
        [Required]
        public string HesapAdi { get; set; }
        public string HesapAdi2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string KartTipi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string FaturaAdresi1 { get; set; }     
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string FaturaAdresi2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string FaturaAdresi3 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Telefon { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Telefon2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Faks1 { get; set; }  
        [Column(TypeName = "nvarchar")]
        [StringLength(15)] 
        public string Faks2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string Yetkili { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(70)] 
        public string WebAdresi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string VergiDairesi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string VergiNo { get; set; }
        public int IskontoOrani { get; set; }
        public int OpsiyonGunu { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string OdemeGunu { get; set; }    
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string DovizCinsi { get; set; }
        [Column(TypeName = "money")]
        public decimal KrediLimiti { get; set; }
        [Column(TypeName = "money")]
        public decimal DovizKrediLimiti { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string BolgeKodu { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string OzelKodu { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string GrupKodu { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string TipKodu { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod1 { get; set; }  
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod2 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod3 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod4 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod5 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod6 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod7 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod8 { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)] 
        public string Kod9 { get; set; }
        [Column(TypeName = "money")]
        public decimal Kod10 { get; set; }
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
        public string Aciklama1 { get; set; }
        [Column(TypeName = "text")]
        public string Aciklama2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string NufusCuzdanSeriNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string TCKimlikNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string AnaAdi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string BabaAdi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string DogumTarihi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string DogumYeri { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string KefilAdi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilTelefon { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilNufusCuzdanSeriNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilTCKimlikNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilAnaAdi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilBabaAdi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KefilDogumTarihi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)] 
        public string KefilDogumYeri { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string KefilAdresi1 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string KefilAdresi2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)] 
        public string TeslimAlan { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string TeslimAdresi1 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string TeslimAdresi2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdresi3 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime KayitSaati { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string KayitKaynak { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Degistiren { get; set; } 
        public DateTime DegisiklikTarihi { get; set; } 
        public DateTime DegisiklikSaati { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string DegisiklikKaynak { get; set; }    
        [Column(TypeName = "decimal(18,0)")]
        public decimal RowID { get; set; }



        
            




    }
}