namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_NETTINGSTOBI
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
        [StringLength(4)]
        public string TraderId { get; set; }

        [Required]
        [StringLength(4)]
        public string AccountingAreaId { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountingGroupId { get; set; }

        [Required]
        [StringLength(8)]
        public string MarketID { get; set; }

        [Required]
        [StringLength(2)]
        public string Ejecutar { get; set; }
    }
}
