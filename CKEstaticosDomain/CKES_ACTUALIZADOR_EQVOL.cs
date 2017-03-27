namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ACTUALIZADOR_EQVOL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string EMP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string SetEstadistico { get; set; }
    }
}
