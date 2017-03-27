namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(10)]
        public string CIF { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaEntrada { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }

        public virtual ICollection<PedidiosProveedor> PedidiosProveedor { get; set; }

        public virtual ICollection<LineasPedidosCliente> LineasPedidoClientes { get; set; }

    }
}
