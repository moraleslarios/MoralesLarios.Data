namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_BORRADO_PORTFOLIO
    {
        [Key]
        public int IdTabla { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreTabla { get; set; }

        [Required]
        [StringLength(50)]
        public string CampoTabla { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoTabla { get; set; }
    }
}
