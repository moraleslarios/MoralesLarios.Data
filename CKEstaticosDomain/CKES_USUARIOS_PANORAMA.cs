namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_USUARIOS_PANORAMA
    {
        [Key]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Required]
        [StringLength(50)]
        public string IdUsuarioPanPwd { get; set; }

        [Required]
        [StringLength(4)]
        public string IdEntidad { get; set; }
    }
}
