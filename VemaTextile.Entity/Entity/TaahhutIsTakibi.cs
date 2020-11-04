using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class TaahhutIsTakibi
    {

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal IdNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

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
        [StringLength(20)]
        public string IgdasBolgesi { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string IgdasaVerildi { get; set; }

        public DateTime IgdasaVerilmeTarihi { get; set; }

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
        public string SayacTakildi { get; set; }
        public DateTime SayacTakilmaTarihi { get; set; }

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
        [StringLength(1)]
        public string GazAcildi { get; set; }

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

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string IgdasAbonelik { get; set; }

        public DateTime IgdasAbonelikTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string RoleveAlindi { get; set; }

        public DateTime RoleveAlinmaTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string KontrolYapildi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string IgdasMuhendisi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiMarka { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiModeli { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiKapasite { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiGaranti { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorMarka { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorTipi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorModeli { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KombiSeriNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorGaranti { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaTipi10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu5 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu6 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu7 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string OdaOlcu10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu4 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu6 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu7 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu8 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu9 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string RadyatorOlcu10 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TesisatCinsi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarihi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }
    }
}