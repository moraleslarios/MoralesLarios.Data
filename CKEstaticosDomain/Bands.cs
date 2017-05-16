namespace DataDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bands
    {
        [Key]
        public int IdBand { get; set; }

        [Required]
        [StringLength(50)]
        public string BandName { get; set; }
    }
}
