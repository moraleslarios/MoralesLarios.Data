namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEHD_INCIDENCIAS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdIncidencia { get; set; }

        [Column(TypeName = "text")]
        public string Subject { get; set; }

        [StringLength(4)]
        public string IdEntidad { get; set; }

        [StringLength(50)]
        public string SubEntidad { get; set; }

        [StringLength(64)]
        public string NombreContacto { get; set; }

        [StringLength(50)]
        public string Concepto { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaCierre { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public DateTime? FechaReportadoProveedor { get; set; }

        public DateTime? FechaCierreCECA { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(4)]
        public string Prioridad { get; set; }

        [StringLength(50)]
        public string IncidenciaPS { get; set; }

        [StringLength(50)]
        public string IncidenciaCodCECA { get; set; }

        [StringLength(50)]
        public string Bloque { get; set; }

        [StringLength(64)]
        public string Persona { get; set; }

        [StringLength(64)]
        public string PersonaCierre { get; set; }

        [Column(TypeName = "ntext")]
        public string Incidencia { get; set; }

        [Column(TypeName = "ntext")]
        public string Respuesta { get; set; }

        [StringLength(50)]
        public string StatusProveedor { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }

        [StringLength(2)]
        public string ComputaEstadisticas { get; set; }

        public int? IdCorteServicio { get; set; }

        public DateTime? FechaReportadoInterno { get; set; }

        public int? IdProducto { get; set; }

        public DateTime? FechaEstimada { get; set; }

        [StringLength(32)]
        public string TextoBusquedaRapida { get; set; }
    }
}
