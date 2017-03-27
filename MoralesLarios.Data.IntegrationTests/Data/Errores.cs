namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Errores
    {
        public int ID { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(2000)]
        public string ErrorDesc { get; set; }
    }
}
