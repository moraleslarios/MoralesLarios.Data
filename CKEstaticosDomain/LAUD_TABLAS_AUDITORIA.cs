namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LAUD_TABLAS_AUDITORIA
    {
        [Key]
        [StringLength(50)]
        public string IdTabla { get; set; }

        [Required]
        [StringLength(16)]
        public string Owner { get; set; }
    }
}
