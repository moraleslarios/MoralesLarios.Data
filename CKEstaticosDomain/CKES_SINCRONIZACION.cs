namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_SINCRONIZACION
    {
        [Key]
        public int Id_Sinc { get; set; }

        [Required]
        [StringLength(1000)]
        public string RutaOrigen { get; set; }

        [Required]
        [StringLength(1000)]
        public string RutaDestino { get; set; }

        [Required]
        [StringLength(50)]
        public string Extensiones { get; set; }

        [Required]
        [StringLength(4)]
        public string OrdenEjecucion { get; set; }

        [Required]
        [StringLength(20)]
        public string MascaraFichero { get; set; }

        public int NumFicherosAntiguosDestino { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
