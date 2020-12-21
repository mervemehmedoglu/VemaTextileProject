using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class TaahhutIsTakibi
    {
        [Key]
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdres1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdres2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatAdres3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Telefon3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TesisatNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string YapilanIs { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(3)]
        public string AgizSayisi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Usta { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string AnlasmaYapildi { get; set; }

        public DateTime AnlasmaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string IseBaslandi { get; set; }

        public DateTime IseBaslamaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string ProjeCizildi { get; set; }
        public DateTime ProjeCizilmeTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string IsBitirildi { get; set; }

        public DateTime IsBitirilmeTarihi { get; set; }
        
        [Column(TypeName = "money")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal PesinatTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal TaksitSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal VadeFarkiOrani { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string ProjeOnaylandi { get; set; }

        public DateTime ProjeOnaylamaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string SozlesmeYapildi { get; set; }
        public DateTime SozlesmeYapilmaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Randevu1 { get; set; }
        public DateTime Randevu1Tarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Randevu2 { get; set; }
        public DateTime Randevu2Tarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Randevu3 { get; set; }

        public DateTime Randevu3Tarihi { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Eksikler1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Eksikler2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Eksikler3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string TeklifNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string FaturaNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Notlar1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Notlar2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Notlar3 { get; set; }

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
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

       
    }
}