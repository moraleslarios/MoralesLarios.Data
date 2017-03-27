namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PedidosClientes
    {
        [Key]
        public int IdPedido { get; set; }

        public int IdCliente { get; set; }

        public int? IdFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaPedido { get; set; }

        [StringLength(30)]
        public string FormaPago { get; set; }

        public decimal ImporteCliente { get; set; }

        public decimal? DescuentoImporteCliente { get; set; }

        public decimal ImporteProveedor { get; set; }

        public decimal? DescuentoImporteProveedor { get; set; }

        public decimal SubTotal { get; set; }

        public decimal IVA { get; set; }

        public decimal IVAImporte { get; set; }

        public bool EsFacturado { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }


        public Clientes Cliente { get; set; }

        public Facturas Factura { get; set; }

        public ICollection<LineasPedidosCliente> LineasPedidoClientes { get; set; }

    }
}
