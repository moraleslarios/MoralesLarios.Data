namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKET_PARAM_INFORMES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string IdUsuarioPan { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string PortfolioID { get; set; }

        [StringLength(512)]
        public string Campos { get; set; }

        [Required]
        [StringLength(2)]
        public string OrdenEjecucion { get; set; }
    }
}
