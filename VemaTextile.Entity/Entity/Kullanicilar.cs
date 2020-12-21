﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Entity.Entity
{
    public class Kullanicilar
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string KullaniciAdi { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Sifre { get; set; }
     
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kaydeden { get; set; }

        public DateTime KayitTarih { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Degistiren { get; set; }

        public DateTime DegisiklikTarihi { get; set; }


    }
}