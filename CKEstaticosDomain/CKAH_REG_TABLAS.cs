namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKAH_REG_TABLAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string NombreTabla { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(16)]
        public string Grupo { get; set; }

        public int NumReg { get; set; }
    }
}
