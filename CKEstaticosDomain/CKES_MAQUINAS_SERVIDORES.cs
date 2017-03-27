namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_MAQUINAS_SERVIDORES
    {
        [Key]
        public int IdMaquinaCECA { get; set; }

        [Required]
        [StringLength(32)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(32)]
        public string Dominio { get; set; }

        [StringLength(32)]
        public string TipoServidor { get; set; }

        [StringLength(50)]
        public string NombreDNS { get; set; }

        [StringLength(32)]
        public string IdNombreCluster { get; set; }

        [Required]
        [StringLength(15)]
        public string DirIPInterna { get; set; }

        [StringLength(15)]
        public string DirIPHidra { get; set; }

        [StringLength(50)]
        public string Fabricante { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        [StringLength(50)]
        public string RAM { get; set; }

        [StringLength(50)]
        public string DiscoDuro { get; set; }

        [StringLength(50)]
        public string Procesador { get; set; }

        public DateTime? FechaCompra { get; set; }

        [StringLength(32)]
        public string IdCompra { get; set; }

        public DateTime? FinGarantia { get; set; }

        [StringLength(3)]
        public string Entorno { get; set; }

        [StringLength(50)]
        public string Agrupacion { get; set; }

        [StringLength(50)]
        public string Detalle { get; set; }

        public DateTime? FechaBaja { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
