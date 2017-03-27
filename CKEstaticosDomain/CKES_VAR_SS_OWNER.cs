namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_VAR_SS_OWNER
    {
        [Key]
        [StringLength(4)]
        public string OWNER { get; set; }

        public int ORDENEJECUCION { get; set; }
    }
}
