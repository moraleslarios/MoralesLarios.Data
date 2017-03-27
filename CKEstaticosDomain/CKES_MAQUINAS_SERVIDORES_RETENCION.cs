namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_MAQUINAS_SERVIDORES_RETENCION
    {
        [Key]
        [Column(Order = 0)]
        public int idServidoresRetencion { get; set; }

        [StringLength(256)]
        public string ServidorOrigen { get; set; }

        [StringLength(256)]
        public string Ruta { get; set; }

        [StringLength(32)]
        public string TipoArchivo { get; set; }

        [StringLength(32)]
        public string tiempoRetencion { get; set; }

        [StringLength(32)]
        public string IdentificadorEnTSM { get; set; }

        [StringLength(512)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
