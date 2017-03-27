namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_SCRIPTS_SEG
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdScript { get; set; }

        public DateTime? FechaGeneracion { get; set; }

        public DateTime? FechaSolDesarrollo { get; set; }

        public DateTime? FechaEnDesarrollo { get; set; }

        public DateTime? FechaSolPre { get; set; }

        public DateTime? FechaEnPre { get; set; }

        public DateTime? FechaSolPro { get; set; }

        public DateTime? FechaEnPro { get; set; }

        [StringLength(256)]
        public string NombreProveedor { get; set; }

        [StringLength(256)]
        public string NombreInterno { get; set; }

        [StringLength(256)]
        public string NombreSistDatos { get; set; }

        [Required]
        [StringLength(2)]
        public string EnviarDescentralizadas { get; set; }

        public DateTime? FechaEnvioDescentralizadas { get; set; }

        [StringLength(1024)]
        public string RutaRed { get; set; }

        [StringLength(1024)]
        public string RutaRedScriptRelacionadoDatos { get; set; }

        [StringLength(1024)]
        public string RutaRedDescentralizadas { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }

        [Required]
        [StringLength(128)]
        public string IdProducto { get; set; }

        [StringLength(1024)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string IncidenciaPS { get; set; }

        [StringLength(50)]
        public string IncidenciaCodCECA { get; set; }
    }
}
