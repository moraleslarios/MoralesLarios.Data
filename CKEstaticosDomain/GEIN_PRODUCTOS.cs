namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_PRODUCTOS
    {
        [Key]
        public int IdProducto { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [StringLength(128)]
        public string Proveedor { get; set; }

        [StringLength(256)]
        public string Descripcion { get; set; }

        [StringLength(30)]
        public string TipoProducto { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
