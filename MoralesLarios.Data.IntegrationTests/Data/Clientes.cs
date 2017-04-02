namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    public partial class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(10)]
        public string CIF { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaEntrada { get; set; }

        [StringLength(30)]
        public string FormaPago { get; set; }

        public int? PeriodoPago { get; set; }

        [StringLength(1000)]
        public string Comentarios { get; set; }

        public virtual ICollection<PedidosClientes> PedidiosCliente { get; set; }
        public virtual ICollection<Facturas> Facturas { get; set; }

    }
}
