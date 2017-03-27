namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_GUARDIAS_INTERVENCIONES
    {
        [Key]
        public int IdIntervencion { get; set; }

        [Required]
        [StringLength(32)]
        public string IdAgrupacion { get; set; }

        public int IdTipoIntervencion { get; set; }

        public DateTime FechaIntervencionInicio { get; set; }

        public DateTime FechaIntervencionFin { get; set; }

        public double? Importe { get; set; }

        [StringLength(512)]
        public string Descripcion { get; set; }

        [StringLength(64)]
        public string NombreTecnico { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
