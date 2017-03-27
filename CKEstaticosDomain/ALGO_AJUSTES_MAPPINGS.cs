namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALGO_AJUSTES_MAPPINGS
    {
        [Key]
        [StringLength(25)]
        public string ContrapartidaAlgo { get; set; }

        [StringLength(14)]
        public string ContrapartidaPanorama { get; set; }
    }
}
