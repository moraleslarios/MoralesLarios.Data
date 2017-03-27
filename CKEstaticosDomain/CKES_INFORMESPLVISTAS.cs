namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_INFORMESPLVISTAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string TradingAreaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string PortfolioId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string Calculo { get; set; }

        [Required]
        [StringLength(2)]
        public string Ejecutar { get; set; }
    }
}
