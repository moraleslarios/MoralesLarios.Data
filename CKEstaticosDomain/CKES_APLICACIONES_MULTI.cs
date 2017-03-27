namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_APLICACIONES_MULTI
    {
        [Key]
        public int IdAplicacion { get; set; }

        [StringLength(4)]
        public string PrefijoTabla { get; set; }

        [Required]
        [StringLength(32)]
        public string SNameAplicacion { get; set; }

        [Required]
        [StringLength(128)]
        public string NombreAplicacion { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }

        [StringLength(6)]
        public string Version { get; set; }
    }
}
