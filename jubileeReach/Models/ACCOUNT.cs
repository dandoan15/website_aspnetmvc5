namespace jubileeReach.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNTS")]
    public partial class ACCOUNT
    {
        public Guid ACCOUNTID { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(30)]
        public string LAST_NAME { get; set; }

        [StringLength(45)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string USERNAME { get; set; }

        [StringLength(30)]
        public string USER_PASS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATION_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MODIFIED_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RECENT_LOGIN { get; set; }

        public bool? ISACTIVE { get; set; }
    }
}
