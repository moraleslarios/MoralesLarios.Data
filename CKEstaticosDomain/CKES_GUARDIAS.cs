namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_GUARDIAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string idAgrupacion { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public double? Importe { get; set; }

        [Required]
        [StringLength(64)]
        public string NombreTecnico { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
