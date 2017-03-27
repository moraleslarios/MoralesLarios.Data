namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDADES_TIPO_CONTACTO
    {
        [Key]
        public int IdTipoContacto { get; set; }

        [StringLength(50)]
        public string NombreTipo { get; set; }

        [StringLength(128)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
