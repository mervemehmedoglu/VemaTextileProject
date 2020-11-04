using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutProjeTakibi
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
        [StringLength(50)]
        public string TesisatNo { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal DAgizSayisi { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal DAdet { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal KAgizSayisi { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal KAdet { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal KalDSayisi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KalBCinsi { get; set; }

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
        public string Muhendis { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string GazBolgesi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Randevu1Eksik { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Randevu2Eksik { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Randevu3Eksik { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string GMuhendis { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SeriNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string AnlasmaYapildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string IseBaslandi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string IsBitirildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string RoleveAlindi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string ProjeCizildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string ProjeVerildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string ProjeOnaylandi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string SozlesmeYapildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string SayacTakildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Randevu1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Randevu2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Randevu3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string KontrolYapildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string GazAcildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string CihazCalisti { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Diger3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Diger1Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Diger2Aciklama { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Diger3Aciklama { get; set; }

        public DateTime AnlasmaYapildiTarih { get; set; }

        public DateTime IseBaslandiTarih { get; set; }

        public DateTime IsBitirildiTarih { get; set; }

        public DateTime RoleveAlindiTarih { get; set; }

        public DateTime ProjeCizildiTarih { get; set; }

        public DateTime ProjeVerildiTarih { get; set; }

        public DateTime ProjeOnaylandiTarih { get; set; }

        public DateTime SozlesmeYapildiTarih { get; set; }

        public DateTime SayacTakildiTarih { get; set; }

        public DateTime Randevu1Tarih { get; set; }

        public DateTime Randevu2Tarih { get; set; }

        public DateTime Randevu3Tarih { get; set; }

        public DateTime KontrolYapildiTarih { get; set; }

        public DateTime GazAcildiTarih { get; set; }

        public DateTime CihazCalistiTarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string CihazPrimi { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string AboneligiVar { get; set; }

        public DateTime AbonelikTarih { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AnlasmaTutari { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal NakitTahsilat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Senetler { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cekler { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProjeMaliyeti { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Iadeler { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Iscilik { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal IscilikDiger { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SenetVadeFarki { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CekVadeFarki { get; set; }


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

        [Column(TypeName = "decimal(18,2)")]
        public decimal EkMaliyet { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal EkMaliyetYuzde { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string AnlasmaTutariEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string PesinatEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string SenetlerEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string CeklerEvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string IadelerEvrakNo { get; set; }


        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}