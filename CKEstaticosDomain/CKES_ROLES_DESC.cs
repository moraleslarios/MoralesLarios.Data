namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ROLES_DESC
    {
        [Key]
        [StringLength(16)]
        public string IdRol { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
