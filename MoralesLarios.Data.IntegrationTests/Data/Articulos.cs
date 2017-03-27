namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articulos
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required]
        [StringLength(50)]
        public string Referencia { get; set; }

        [StringLength(50)]
        public string Familia { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaEntrada { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }

        public virtual ICollection<LineasPedidosProveedor> LineasPedidosProveedores { get; set; }
        public virtual ICollection<LineasPedidosCliente> LineasPedidoClientes { get; set; }
    }
}
