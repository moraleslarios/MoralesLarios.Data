namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_MAQUINAS_CLIENTES
    {
        [Key]
        [StringLength(16)]
        public string IdMaquinaCECA { get; set; }

        [Required]
        [StringLength(32)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(32)]
        public string Dominio { get; set; }

        [StringLength(8)]
        public string Fabricante { get; set; }

        [StringLength(8)]
        public string Modelo { get; set; }

        [StringLength(8)]
        public string RAM { get; set; }

        [StringLength(32)]
        public string DiscoDuro { get; set; }

        [StringLength(16)]
        public string Procesador { get; set; }

        public DateTime? FechaCompra { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
