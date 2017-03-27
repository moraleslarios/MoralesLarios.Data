namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDADES
    {
        [Key]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(3)]
        public string PrefijoVPD { get; set; }

        [StringLength(2)]
        public string HabilitaSubentidad { get; set; }
    }
}
