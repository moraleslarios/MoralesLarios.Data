namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LICENCIAS_ADAPTIV
    {
        [Key]
        [StringLength(10)]
        public string IdEntidad { get; set; }

        [Required]
        [StringLength(512)]
        public string LicenciaAdaptiv { get; set; }

        public DateTime FechaLicencia { get; set; }
    }
}
