namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_ETIQUETAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NOrden { get; set; }

        [Required]
        [StringLength(25)]
        public string NombreControl { get; set; }

        [StringLength(25)]
        public string Etiqueta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
