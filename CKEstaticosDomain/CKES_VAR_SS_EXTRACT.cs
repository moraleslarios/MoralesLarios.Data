namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_VAR_SS_EXTRACT
    {
        [Required]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string VarStatisticsSet { get; set; }

        [Required]
        [StringLength(4000)]
        public string DimHorizontal { get; set; }

        [Required]
        [StringLength(4000)]
        public string DimVertical { get; set; }

        [Required]
        [StringLength(4)]
        public string OrdenEjecucion { get; set; }
    }
}
