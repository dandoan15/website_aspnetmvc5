using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jubileeReach.Models
{
    public class PRODUCT_CATEGORY_SIZES_IMAGES
    {
        [Key]
        public int PRODUCTID { get; set; }
        public Byte[] IMG1 { get; set; }
        public string BRAND { get; set; }
        public string CAT_NAME { get; set; }
        public string SIZE { get; set; }
        public decimal SALE_PRICE { get; set; }
        public string COLOR_NAME { get; set; }
        public string QUALITY_NAME { get; set; }
    }
}