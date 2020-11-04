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
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(8)]
        public string EvrakNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string GörevID { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Key]
        [Required]
        public DateTime TaskStartTime { get; set; }

        [Required]
        public DateTime TaskFinishTime { get; set; }

        [Required]
        public DateTime BaslangicPlanTarihi { get; set; }

        [Required]
        public DateTime BitisPlanTarihi { get; set; }

        [Key]
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
        [StringLength(40)]
        public string SablonID{ get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string OnculTask { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan2 { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Durum { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(1)]
        public string Okundu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string CHKKodu { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string CHKAdi { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Onem { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }


    }
}