namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_RUTAS_FILECLEANER
    {
        [Key]
        public int IdFileCleaner { get; set; }

        [Required]
        [StringLength(16)]
        public string IdMaquinaCECA { get; set; }

        [Required]
        public string Ruta { get; set; }

        [Required]
        [StringLength(50)]
        public string Opcion { get; set; }

        public int Cantidad { get; set; }

        [StringLength(3)]
        public string Extension { get; set; }

        [Required]
        [StringLength(50)]
        public string Tarea { get; set; }

        public string RutaAccion { get; set; }

        [StringLength(2)]
        public string Subcarpetas { get; set; }

        [StringLength(2)]
        public string ZipUnicoFichero { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
