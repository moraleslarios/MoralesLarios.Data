namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_POSITIONSTOBI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string TradingAreaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string PortfolioId { get; set; }

        [Required]
        [StringLength(2)]
        public string PrefijoEntidad { get; set; }

        [Required]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Required]
        [StringLength(15)]
        public string Fecha { get; set; }

        [Required]
        [StringLength(4)]
        public string TraderId { get; set; }

        [Required]
        [StringLength(4)]
        public string AccountingAreaId { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountingGroupId { get; set; }

        [Required]
        [StringLength(2)]
        public string Ejecutar { get; set; }
    }
}
