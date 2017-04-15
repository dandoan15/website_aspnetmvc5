using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jubileeReach.Models
{
    public class PURCHASEINFO
    {
        [Key]
        public int ORDER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public DateTime PICK_UP_TIME { get; set; }
        public DateTime DATE_PURCHASED { get; set; }
        public string PHONENUMBER { get; set; }
        public decimal SALE_PRICE { get; set; }
        public string BRAND { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
    }
}