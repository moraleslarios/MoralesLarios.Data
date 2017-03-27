namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_GUARDIAS_AGRUPACIONES
    {
        [Key]
        [StringLength(32)]
        public string IdAgrupacion { get; set; }

        [Required]
        [StringLength(5)]
        public string AnyoAsociado { get; set; }

        [Required]
        [StringLength(2)]
        public string MesAsociado { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
