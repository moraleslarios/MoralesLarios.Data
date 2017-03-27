namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_DEPARTAMENTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string IdDepartamento { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NombreDepartamento { get; set; }

        [StringLength(50)]
        public string DepartamentoPadre { get; set; }

        [StringLength(50)]
        public string IdArea { get; set; }

        public int? IdProducto { get; set; }
    }
}
