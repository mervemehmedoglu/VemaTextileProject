﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class MuhasebeGrupKartlari
    {
        [Key]
        public int ID { get; set; }

        public int IDHesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HesapAdi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string AlimlarHesabi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string SatislarHesabi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string AlimdanladelerHesabi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string SatistanladelerHesabi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Diger1 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Diger2 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Diger3 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Diger4 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Diger5 { get; set; }

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

        

    }
}