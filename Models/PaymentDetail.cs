using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirtDotNetCRUD.Models
{
    public class PaymentDetail
    {
        [Key]
        public int  PaymentDetailId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CardOwnerNAme { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        public string CardNumber { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        public string ExpirationDate { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        public string SecurityCode { get; set; } = "";

    } 
}