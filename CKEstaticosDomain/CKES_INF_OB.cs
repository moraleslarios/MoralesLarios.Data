namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_INF_OB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(64)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string ESQUEMA { get; set; }

        public int? INITIAL { get; set; }

        public int? NEXT { get; set; }

        public decimal? PORCENT_NEXTINITIAL { get; set; }

        public int? RESERVADO { get; set; }

        public decimal? PORCENT_INITIALRESERVADO { get; set; }

        public decimal? PORCENT_NEXTRESERVADO { get; set; }

        public int? USADO { get; set; }

        public decimal? PORCENT_USADORESERVADO { get; set; }

        public int? LIBRE { get; set; }

        public decimal? PORCENT_LIBRERESERVADO { get; set; }

        public int? NUMEXT { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaInforme { get; set; }
    }
}
