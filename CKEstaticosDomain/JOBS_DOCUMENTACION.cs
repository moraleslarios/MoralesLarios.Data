namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_DOCUMENTACION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string IdJob { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Paso { get; set; }

        [StringLength(64)]
        public string NombreDescriptivo { get; set; }

        [StringLength(10)]
        public string ColorGrafico { get; set; }

        [StringLength(50)]
        public string Propietario { get; set; }

        [StringLength(64)]
        public string Tipologia { get; set; }

        public string Descripcion { get; set; }

        [StringLength(50)]
        public string ServidorEjecucion { get; set; }

        [StringLength(128)]
        public string ServidorRuta { get; set; }

        [StringLength(128)]
        public string RutaSSafe { get; set; }

        public int? JobIdCalendario { get; set; }

        [StringLength(128)]
        public string JobHorario { get; set; }

        [StringLength(128)]
        public string EncadenadoA { get; set; }

        public int? Prioridad { get; set; }

        [StringLength(2)]
        public string TareaProgramadaCrear { get; set; }

        [StringLength(3)]
        public string TareaProgramadaDefValue { get; set; }

        [StringLength(1024)]
        public string OnErrorExplotacion { get; set; }

        [StringLength(2048)]
        public string OnErrorTecnico { get; set; }

        [StringLength(2048)]
        public string OnErrorFuncional { get; set; }

        public string HistoricoErrores { get; set; }
    }
}
