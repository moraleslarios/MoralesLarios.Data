namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("LineasPedidosCliente")]
    public partial class LineasPedidosCliente
    {
        [Key]
        public int IdLineaPedido { get; set; }

        public int IdPedido { get; set; }

        public int IdArticulo { get; set; }

        public int IdProveedor { get; set; }

        public decimal PrecioProveedor { get; set; }

        public decimal? DescuentoProveedor { get; set; }

        public decimal? DescuentoImporteProveedor { get; set; }

        public decimal PrecioCliente { get; set; }

        public decimal? DescuentoCliente { get; set; }

        public decimal? DescuentoImporteCliente { get; set; }

        public int Cantidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal ImporteProveedor { get; set; }

        public decimal ImporteCliente { get; set; }

        public decimal IVA { get; set; }

        public decimal IVAImporte { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }


        public virtual PedidosClientes PedidoCliente { get; set; }
        public virtual Articulos Articulo { get; set; }
        public virtual Proveedores Proveedor { get; set; }
    }
}
