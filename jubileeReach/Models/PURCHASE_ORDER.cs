using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    public partial class PURCHASE_ORDER
    {
        [Key]
        public int ORDER_ID { get; set; }

        public int? ACCOUNT_ID { get; set; }

        [StringLength(100)]
        public string ITEM_DESRIPRION { get; set; }

        public decimal? PRICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_PURCHASED { get; set; }

        public byte[] IMG { get; set; }
    }
}
