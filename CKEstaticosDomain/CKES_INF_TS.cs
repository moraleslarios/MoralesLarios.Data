namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_INF_TS
    {
        [Key]
        [Column(Order = 0)]
        public string TABLESPACE_NAME { get; set; }

        public int? MB_RESERVADOS { get; set; }

        public decimal? MB_LIBRES { get; set; }

        public decimal? MB_USADOS { get; set; }

        public int? PCT_LIBRE { get; set; }

        public int? PCT_USADO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHAINFORME { get; set; }
    }
}
