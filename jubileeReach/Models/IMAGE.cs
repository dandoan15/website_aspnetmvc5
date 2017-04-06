namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IMAGES")]
    public partial class IMAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMAGE()
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
