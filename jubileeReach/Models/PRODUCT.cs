namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        //internal IMAGE IMAGE;

        public int PRODUCTID { get; set; }

        public int? DEP_ID { get; set; }

        public int? CAT_ID { get; set; }

        public int? SIZE_ID { get; set; }

        public int? IMG_ID { get; set; }

        public int? COLOR_ID { get; set; }

        [StringLength(100)]
        public string ITEM_DESCRIPTION { get; set; }

        [StringLength(20)]
        public string BRAND { get; set; }

        public decimal? RETAIL_PRICE { get; set; }

        public decimal? SALE_PRICE { get; set; }

        public int? QUAL_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MODIFY_DATE { get; set; }

        public bool? IS_AVAILABLE { get; set; }

        public bool? FEATURED { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        public virtual COLOR COLOR { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        public virtual IMAGE IMAGE { get; set; }

        public virtual QUALITY QUALITY { get; set; }

        public virtual SIZE SIZE { get; set; }
    }
}
