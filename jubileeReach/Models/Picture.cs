namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Picture")]
    public partial class Picture
    {
        public int pictureID { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        public byte[] image { get; set; }

        [StringLength(20)]
        public string brand { get; set; }

        public decimal? price { get; set; }

        [StringLength(20)]
        public string size { get; set; }

        [StringLength(20)]
        public string category { get; set; }
    }
}
