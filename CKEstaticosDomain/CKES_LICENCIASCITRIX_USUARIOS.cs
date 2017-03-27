namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_LICENCIASCITRIX_USUARIOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string UsuarioCitrix { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Procedencia { get; set; }
    }
}
