namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_NODOS_ROLES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Nodo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string IdRol { get; set; }

        [StringLength(2)]
        public string Acceso { get; set; }
    }
}
