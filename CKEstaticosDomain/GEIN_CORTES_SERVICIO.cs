namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_CORTES_SERVICIO
    {
        [Key]
        public int IdCorteServicio { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [StringLength(128)]
        public string Subject { get; set; }

        [StringLength(2048)]
        public string Incidencia { get; set; }

        [Required]
        [StringLength(64)]
        public string Persona { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
