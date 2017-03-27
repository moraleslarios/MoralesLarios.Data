namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_TABLAS
    {
        [Key]
        [StringLength(96)]
        public string NombreTabla { get; set; }

        [StringLength(2)]
        public string GenerarScript { get; set; }

        [StringLength(2)]
        public string IncluirFiltroVista { get; set; }

        [StringLength(100)]
        public string NodoAsociado { get; set; }
    }
}
