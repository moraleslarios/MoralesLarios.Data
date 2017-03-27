namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKET_PARAM_PROPS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Tipo { get; set; }
    }
}
