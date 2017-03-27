namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LOG_TRAZAS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdTraza { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IdSesion { get; set; }

        [Required]
        [StringLength(64)]
        public string Usuario { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Sentencia { get; set; }

        public DateTime FechaTraza { get; set; }

        [StringLength(6)]
        public string TipoSentencia { get; set; }
    }
}
