namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_BACKUPS
    {
        [Key]
        [StringLength(18)]
        public string IdCopiaSeguridad { get; set; }

        public short? OrdenDia { get; set; }

        [Required]
        [StringLength(8)]
        public string IdUsuario { get; set; }

        public DateTime? FechaSolicitud { get; set; }

        public DateTime FechaGrabacion { get; set; }

        public DateTime? FechaCierre { get; set; }

        public DateTime? FechaReferencia { get; set; }

        [StringLength(256)]
        public string Descripcion { get; set; }

        public short numCopias { get; set; }

        [StringLength(128)]
        public string Ubicacion { get; set; }

        [Column(TypeName = "ntext")]
        public string Contenido { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
