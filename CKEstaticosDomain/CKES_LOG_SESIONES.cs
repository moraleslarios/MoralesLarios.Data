namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LOG_SESIONES
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdSesion { get; set; }

        [Required]
        [StringLength(10)]
        public string IdUsuario { get; set; }

        [Required]
        [StringLength(16)]
        public string IdMaquina { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
