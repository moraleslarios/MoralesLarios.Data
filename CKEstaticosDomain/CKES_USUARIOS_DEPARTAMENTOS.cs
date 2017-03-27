namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_USUARIOS_DEPARTAMENTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string IdUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
