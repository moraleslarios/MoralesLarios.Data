namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKAH_FECHAS_HIS
    {
        [Key]
        public DateTime FechaBackup { get; set; }

        public DateTime? FechaBorradoHis { get; set; }
    }
}
