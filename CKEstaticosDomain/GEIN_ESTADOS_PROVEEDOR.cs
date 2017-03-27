namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_ESTADOS_PROVEEDOR
    {
        [Key]
        public int idEstadoProveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
