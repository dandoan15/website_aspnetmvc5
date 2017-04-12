using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    [Table("Table")]
    public partial class Table
    {
        [Key]
        public int pictureID { get; set; }

        public string name { get; set; }

        public byte[] image { get; set; }
    }
}
