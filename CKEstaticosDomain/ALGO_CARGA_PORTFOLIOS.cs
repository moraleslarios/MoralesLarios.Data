namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALGO_CARGA_PORTFOLIOS
    {
        [Key]
        [StringLength(8)]
        public string PortfolioID { get; set; }

        [Required]
        [StringLength(256)]
        public string Calculos { get; set; }

        [Required]
        [StringLength(4)]
        public string IdUsuarioPan { get; set; }

        [StringLength(50)]
        public string ParteFijaFichero { get; set; }

        [Required]
        [StringLength(2)]
        public string Ejecutar { get; set; }

        [StringLength(2)]
        public string Fusionar { get; set; }

        public int? OrdenEjecucion { get; set; }
    }
}
