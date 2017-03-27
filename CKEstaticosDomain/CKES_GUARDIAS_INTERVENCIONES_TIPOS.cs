namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_GUARDIAS_INTERVENCIONES_TIPOS
    {
        [Key]
        public int IdTipoIntervencion { get; set; }

        [Required]
        [StringLength(128)]
        public string Descripcion { get; set; }

        public double? Importe { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
