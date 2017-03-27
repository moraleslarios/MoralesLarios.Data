namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_EXPLOTACION_SEG
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdEjecucion { get; set; }

        [Required]
        [StringLength(15)]
        public string IdJob { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        public int ReturnCode { get; set; }

        [StringLength(2000)]
        public string Solucion { get; set; }
    }
}
