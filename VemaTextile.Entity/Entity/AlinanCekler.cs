﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class AlinanCekler
    {
        [Key]
        public int ID { get; set; }
        public int IDCekKodu { get; set; }
        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string IDCek { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal EvrakNo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string Seri { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Borclu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string BorcluUnvan { get; set; }

        public DateTime AlimTarihi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CekiVeren { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CekiVerenUnvan { get; set; }
        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }
        [Column(TypeName = "money")]
        public decimal TahsilMasrafi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CekTipi { get; set; }
        [Required]
        public DateTime VadeTarihi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sehir { get; set; }
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
        [StringLength(5)]
        public string DovizTL { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }
        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }
        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Banka { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sube { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string BankaHesapNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CekNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string TahsileCikilanBanka { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TahsileCikilanBankaUnvan { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string IslemTipi { get; set; }

       

        public DateTime Tarih { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string SonPozisyon { get; set; }
        [Column(TypeName = "decimal")]
        
        public decimal BordroNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2)]
        public string BordroSeri { get; set; }

        [Column(TypeName = "decimal")]
        public decimal BordroIdNo { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }
        
        
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Kaydeden { get; set; }
        public DateTime KayitTarihi { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Degistiren { get; set; }
        
        public DateTime DegisiklikTarihi { get; set; }
        

       




    }
}