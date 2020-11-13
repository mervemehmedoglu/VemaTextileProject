using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class ProjeGorevler
    {
        [Key]
        public int ID { get; set; }
        public int IDCHKKodu { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CHKKodu { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Required]
        public DateTime TaskStartTime { get; set; }

        [Required]
        public DateTime TaskFinishTime { get; set; }

        [Required]
        public DateTime BaslangicPlanTarihi { get; set; }

        [Required]
        public DateTime BitisPlanTarihi { get; set; }

        
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Usta { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Planlama { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string TaskDuration { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Onculler { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string OnculTask { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan2 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Durum { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Okundu { get; set; }

        

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Onem { get; set; }

       


    }
}