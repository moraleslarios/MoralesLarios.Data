namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALGO_CARGA_SEGUIMIENTO
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdTraza { get; set; }

        [Required]
        [StringLength(50)]
        public string PortfolioID { get; set; }

        public DateTime FechaInicioApertura { get; set; }

        public DateTime? FechaFinApertura { get; set; }

        public DateTime? FechaInicioCalculo { get; set; }

        public DateTime? FechaFinCalculo { get; set; }

        [StringLength(512)]
        public string RutaFichero { get; set; }

        [StringLength(2)]
        public string Resultado { get; set; }
    }
}
