using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    [Table("PURCHASEDEMO")]
    public partial class PURCHASEDEMO
    {
        [Key]
        public int ORDER_ID { get; set; }

        [StringLength(100)]
        public string FIRST_NAME { get; set; }

        [StringLength(100)]
        public string LAST_NAME { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string PICK_UP_TIME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_PURCHASED { get; set; }

        public int? PRODUCTID { get; set; }

        [StringLength(100)]
        public string PHONENUMBER { get; set; }
    }
}
