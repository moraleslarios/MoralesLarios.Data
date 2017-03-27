namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKET_PARAM_INFORMES_V2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string PortfolioID { get; set; }

        public string Campos { get; set; }

        public int OrdenEjecucion { get; set; }

        [StringLength(2)]
        public string MDA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Tipo { get; set; }
    }
}
