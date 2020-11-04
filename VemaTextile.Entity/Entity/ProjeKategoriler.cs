using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VemaTextile.Models.Class
{
    public class ProjeKategoriler
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
        public string ID { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string ParentID { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string ProjectKey { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TaskName { get; set; }

        public DateTime TaskStartTime { get; set; }
        public DateTime TaskFinishTime { get; set; }


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
        [StringLength(5)]
        public string TaskPercentComplete { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Constraint { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string SablonID { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string MilesStone { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string OnculTask { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Kullanan { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }


        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Gun2 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(5)]
        public string Gun3 { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ConstraintDateTime { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SonTarih { get; set; }


        
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal SiraNo { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal Row_ID { get; set; }

    }
}