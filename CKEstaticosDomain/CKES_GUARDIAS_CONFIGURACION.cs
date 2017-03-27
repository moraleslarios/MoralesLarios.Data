namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_GUARDIAS_CONFIGURACION
    {
        [Key]
        [Column(Order = 0)]
        public string DepartamentoDesc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string HorarioGuardias { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
