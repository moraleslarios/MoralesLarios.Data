namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JOBS_QRY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string IdJob { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Orden { get; set; }

        [StringLength(20)]
        public string BDUsuario { get; set; }

        [StringLength(300)]
        public string RutaBackUp { get; set; }

        [Column(TypeName = "ntext")]
        public string Consulta { get; set; }

        [StringLength(100)]
        public string Parametros { get; set; }
    }
}
