namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_GENERAL
    {
        [Key]
        [StringLength(15)]
        public string IdJob { get; set; }

        [StringLength(100)]
        public string SNameAplicacion { get; set; }

        [StringLength(128)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Calendario { get; set; }

        [StringLength(32)]
        public string ServidorEjecucion { get; set; }

        [StringLength(50)]
        public string NombreDNS { get; set; }

        [StringLength(128)]
        public string Horario { get; set; }

        [StringLength(2)]
        public string EsJobsManager { get; set; }

        [StringLength(2)]
        public string EjecutarEnFestivo { get; set; }
    }
}
