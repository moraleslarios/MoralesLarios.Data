namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas
    {
        [Key]
        public int IdFra { get; set; }

        public int IdCliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaInicialFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaFinalFra { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaVto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Importe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ImporteIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SubTotal { get; set; }

        public Clientes Cliente { get; set; }
        public ICollection<PedidosClientes> PedidosClientes { get; set; }
    }
}
