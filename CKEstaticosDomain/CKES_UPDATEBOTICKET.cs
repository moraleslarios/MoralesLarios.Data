namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_UPDATEBOTICKET
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string BoticketError { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string BoticketOk { get; set; }

        [StringLength(2)]
        public string Activado { get; set; }
    }
}
