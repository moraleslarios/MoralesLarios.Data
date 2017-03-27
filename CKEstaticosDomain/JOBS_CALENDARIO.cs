namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_CALENDARIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCalendario { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(2)]
        public string Lunes { get; set; }

        [StringLength(2)]
        public string Martes { get; set; }

        [StringLength(2)]
        public string Miercoles { get; set; }

        [StringLength(2)]
        public string Jueves { get; set; }

        [StringLength(2)]
        public string Viernes { get; set; }

        [StringLength(2)]
        public string Sabado { get; set; }

        [StringLength(2)]
        public string Domingo { get; set; }

        [StringLength(2)]
        public string FestivosEuropeos { get; set; }

        [StringLength(2)]
        public string FestivosTarget { get; set; }

        [StringLength(2)]
        public string DiaMes { get; set; }

        [StringLength(2)]
        public string UltimoDiaHabil { get; set; }

        [StringLength(2)]
        public string PrimerDiaHabil { get; set; }
    }
}
