namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PedidiosProveedor")]
    public partial class PedidiosProveedor
    {
        [Key]
        public int IdPedido { get; set; }

        public int IdProveedor { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaPedido { get; set; }

        public decimal Importe { get; set; }

        [StringLength(30)]
        public string FormaPago { get; set; }

        public decimal SubTotal { get; set; }

        public decimal IVAImporte { get; set; }

        public decimal? DescuentoImporte { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }

        public virtual Proveedores Proveedor { get; set; }

        public virtual ICollection<LineasPedidosProveedor> LineasPedidoProveedor { get; set; }
    }
}
