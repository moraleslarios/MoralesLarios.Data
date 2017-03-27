namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_REMOTEEXEC
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string NombreAplicacion { get; set; }

        [Required]
        [StringLength(100)]
        public string RutaApp { get; set; }

        [StringLength(100)]
        public string ParametrosApp { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        public string Servidor { get; set; }

        [Required]
        [StringLength(50)]
        public string Agrupacion { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
