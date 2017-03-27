namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Opciones
    {
        [Key]
        public int IdOpciones { get; set; }

        [StringLength(50)]
        public string DescripcionOpcion { get; set; }

        [StringLength(500)]
        public string ValorOpcion { get; set; }
    }
}
