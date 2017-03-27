namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDAD_AGRUPACION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IdAgrupacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdEntidad { get; set; }
    }
}
