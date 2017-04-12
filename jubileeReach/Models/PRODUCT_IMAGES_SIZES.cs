using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jubileeReach.Models
{
    public class PRODUCT_IMAGES_SIZES
    {
        [Key]
        public int PRODUCTID { get; set; }
        public string BRAND { get; set; }
        public int SIZE_ID { get; set; }
        public decimal SALE_PRICE { get; set; }
        public string ITEM_DESCRIPTION { get; set; }
        public Byte[] IMG1 { get; set; }
        public Byte[] IMG2 { get; set; }
        public Byte[] IMG3 { get; set; }
        public Byte[] IMG4 { get; set; }
        public string SIZE { get; set; }
        public string QUALITY_NAME { get; set; }
    }
}