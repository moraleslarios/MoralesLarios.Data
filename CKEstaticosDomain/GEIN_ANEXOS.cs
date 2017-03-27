namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GEIN_ANEXOS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdAnexo { get; set; }

        [Required]
        [StringLength(50)]
        public string Tabla { get; set; }

        public int IdIncidencia { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anexo { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
