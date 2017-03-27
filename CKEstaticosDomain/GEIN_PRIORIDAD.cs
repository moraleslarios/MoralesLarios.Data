namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_PRIORIDAD
    {
        [Key]
        public int IdPrioridad { get; set; }

        [Required]
        [StringLength(50)]
        public string Prioridad { get; set; }
    }
}
