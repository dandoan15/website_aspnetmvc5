namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIZES")]
    public partial class SIZE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIZE()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int SIZE_ID { get; set; }

        public int? SIZE_GROUP { get; set; }

        [Column("SIZE")]
        [StringLength(20)]
        public string SIZE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }

        public virtual SIZE_GROUP SIZE_GROUP1 { get; set; }
    }
}
