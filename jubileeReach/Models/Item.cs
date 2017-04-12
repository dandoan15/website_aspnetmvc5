using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    [Table("Item")]
    public partial class Item
    {
        public int itemID { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public decimal OriginalPrice { get; set; }

        public string Quality { get; set; }

        public decimal SalePrice { get; set; }

        public string Size { get; set; }
    }
}
