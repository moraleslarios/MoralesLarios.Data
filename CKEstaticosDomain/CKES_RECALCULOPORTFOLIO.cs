namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_RECALCULOPORTFOLIO
    {
        [Key]
        [StringLength(10)]
        public string PortfolioId { get; set; }

        [Required]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Required]
        [StringLength(2)]
        public string SaveResults { get; set; }

        [StringLength(10)]
        public string Fecha { get; set; }

        public int? Ventana { get; set; }

        public int? OrdenEjecucion { get; set; }
    }
}
