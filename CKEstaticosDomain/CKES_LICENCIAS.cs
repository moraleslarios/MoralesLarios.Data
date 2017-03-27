namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LICENCIAS
    {
        [Key]
        [StringLength(50)]
        public string IdLicencia { get; set; }

        public int IdProducto { get; set; }

        public DateTime FechaCompra { get; set; }

        [Required]
        [StringLength(50)]
        public string IdPedido { get; set; }

        [Required]
        [StringLength(2)]
        public string RenovacionAnual { get; set; }

        [StringLength(128)]
        public string NLicencia { get; set; }

        [StringLength(16)]
        public string Beneficiario { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
