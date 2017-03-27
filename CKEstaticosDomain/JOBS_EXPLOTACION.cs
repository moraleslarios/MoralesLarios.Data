namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_EXPLOTACION
    {
        [Key]
        [StringLength(15)]
        public string IdJob { get; set; }

        [Required]
        [StringLength(100)]
        public string SNameAplicacion { get; set; }

        [StringLength(10)]
        public string BDTipoBD { get; set; }

        [StringLength(32)]
        public string BDNombreServidor { get; set; }

        [StringLength(32)]
        public string BDNombre { get; set; }

        [StringLength(32)]
        public string Servidor { get; set; }

        [StringLength(300)]
        public string RutaLog { get; set; }

        [StringLength(60)]
        public string HorarioEjecucion { get; set; }

        [StringLength(10)]
        public string IdCalendario { get; set; }

        [StringLength(2000)]
        public string Descripcion { get; set; }
    }
}
