using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    [Table("IMAGES")]
    public partial class IMAGES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMAGES()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int IMAGE_TABLE_ID { get; set; }

        public byte[] IMG1 { get; set; }

        public byte[] IMG2 { get; set; }

        public byte[] IMG3 { get; set; }

        public byte[] IMG4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
    }
}
