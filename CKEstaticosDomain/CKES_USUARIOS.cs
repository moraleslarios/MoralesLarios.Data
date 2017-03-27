namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_USUARIOS
    {
        [Key]
        [StringLength(8)]
        public string IdUsuario { get; set; }

        [Required]
        [StringLength(16)]
        public string IdRol { get; set; }

        [Required]
        [StringLength(64)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(64)]
        public string DireccionCorreo { get; set; }

        [StringLength(32)]
        public string Empresa { get; set; }

        [StringLength(12)]
        public string Telefono1 { get; set; }

        [StringLength(12)]
        public string Telefono2 { get; set; }

        [Required]
        [StringLength(8)]
        public string IdResponsable { get; set; }

        [StringLength(2)]
        public string Activo { get; set; }

        [StringLength(16)]
        public string IdMaquina { get; set; }

        [Required]
        [StringLength(9)]
        public string RolAlgoConciliacion { get; set; }

        [Required]
        [StringLength(2)]
        public string RealizaGuardias { get; set; }

        [StringLength(128)]
        public string TelefonosGuardia { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
