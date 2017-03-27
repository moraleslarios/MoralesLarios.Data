namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDADES_CONTACTOS
    {
        [Key]
        [Column(Order = 0)]
        public int IdContacto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string Nombre { get; set; }

        [StringLength(12)]
        public string Telefono1 { get; set; }

        [StringLength(12)]
        public string Telefono2 { get; set; }

        [StringLength(64)]
        public string cargo { get; set; }

        [StringLength(10)]
        public string CITRIX_Maquina { get; set; }

        [StringLength(64)]
        public string direccionCorreo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
