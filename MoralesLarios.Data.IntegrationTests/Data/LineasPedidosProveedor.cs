namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LineasPedidosProveedor")]
    public partial class LineasPedidosProveedor
    {
        [Key]
        public int IdLineaPedido { get; set; }

        public int IdPedido { get; set; }

        public int IdArticulo { get; set; }

        public decimal Precio { get; set; }

        public decimal? Descuento1 { get; set; }

        public decimal? Descuento2 { get; set; }

        public int Cantidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Importe { get; set; }

        public decimal IVA { get; set; }

        public decimal IVAImporte { get; set; }

        public decimal? Descuento1Importe { get; set; }

        public decimal? Descuento2Importe { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }


        public virtual PedidiosProveedor PedidoProveedor { get; set; }
        public virtual Articulos Articulo { get; set; }
    }
}
