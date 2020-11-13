﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class FaturaBilgileri
    {
        [Key]
        public int ID { get; set; }

        public int IDCHKKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CHKKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(57)]
        public string EvrakNo { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "nvarchar")]
        public string CHKAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Tıp { get; set; }

        [Column(TypeName = "money")]
        public decimal Tutar { get; set; }

        [Column(TypeName = "money")]
        public decimal Oran { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string DovizTL{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string DovizCinsi { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizKuru { get; set; }

        [Column(TypeName = "money")]
        public decimal DovizTutar { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kod3 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod4 { get; set; }

        [Column(TypeName = "money")]
        public decimal Kod5 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TeslimAdres3 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama1 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Aciklama2 { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string KDVHesaplama { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string KaynakEvrakTipi { get; set; }

    }
}