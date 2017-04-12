using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace jubileeReach.Models
{
    [Table("CATEGORY")]
    public partial class CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORY()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int CAT_ID { get; set; }

        public int DEP_LINKER { get; set; }

        public int SIZE_GROUP { get; set; }

        [StringLength(30)]
        public string CAT_NAME { get; set; }

        public virtual DEP_LINKER DEP_LINKER1 { get; set; }

        public virtual SIZE_GROUP SIZE_GROUP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
    }
}
