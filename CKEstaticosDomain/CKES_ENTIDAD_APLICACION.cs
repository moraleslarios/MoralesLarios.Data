namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDAD_APLICACION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SNameAplicacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoEnvio { get; set; }

        [Required]
        [StringLength(1)]
        public string Encriptar { get; set; }

        [Required]
        [StringLength(1)]
        public string Zipear { get; set; }
    }
}
