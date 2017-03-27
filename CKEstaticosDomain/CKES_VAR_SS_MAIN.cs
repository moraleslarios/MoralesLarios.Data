namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_VAR_SS_MAIN
    {
        [Key]
        [StringLength(8)]
        public string VAR_SS_ID { get; set; }

        [Required]
        [StringLength(4)]
        public string OWNER { get; set; }

        public int NUMBEROFDAYS { get; set; }

        public int ORDENEJECUCION { get; set; }

        [StringLength(2)]
        public string Ejecutar { get; set; }
    }
}
