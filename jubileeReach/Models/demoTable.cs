namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("demoTable")]
    public partial class demoTable
    {
        public int demotableID { get; set; }

        [StringLength(10)]
        public string Category { get; set; }

        [StringLength(10)]
        public string Tag_color { get; set; }

        [StringLength(10)]
        public string color { get; set; }

        [StringLength(10)]
        public string department { get; set; }

        [StringLength(10)]
        public string brand { get; set; }

        public decimal? retail_price { get; set; }

        public bool? IS_AVAILABLE { get; set; }

        [StringLength(50)]
        public string item_description { get; set; }

        public decimal? sale_price { get; set; }

        [StringLength(20)]
        public string quality { get; set; }

        [StringLength(20)]
        public string size { get; set; }

        public byte[] img { get; set; }
    }
}
