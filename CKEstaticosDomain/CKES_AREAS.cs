namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_AREAS
    {
        [Key]
        [StringLength(50)]
        public string IdArea { get; set; }

        [Required]
        [StringLength(1024)]
        public string Descripcion { get; set; }
    }
}
