namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Albums
    {
        [Key]
        public int IdAlbum { get; set; }

        public int IdBand { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
