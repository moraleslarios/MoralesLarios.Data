namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LICENCIASCITRIX
    {
        [Key]
        [StringLength(30)]
        public string UsuarioCitrix { get; set; }

        public DateTime? FechaCompra { get; set; }

        [Required]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [StringLength(20)]
        public string Agrupacion { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
