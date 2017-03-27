namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ROLES_TABLAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string IdRol { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NombreTabla { get; set; }

        [StringLength(2)]
        public string AccesoTabla { get; set; }
    }
}
