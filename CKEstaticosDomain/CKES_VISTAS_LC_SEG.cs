namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_VISTAS_LC_SEG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVista { get; set; }

        [Key]
        [StringLength(30)]
        public string ProcedimientoAlmacenado { get; set; }

        [StringLength(30)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string DescripcionCorta { get; set; }

        [Column(TypeName = "text")]
        public string DescripcionLarga { get; set; }

        [StringLength(1024)]
        public string Vistas { get; set; }

        [StringLength(1024)]
        public string Usuarios { get; set; }
    }
}
