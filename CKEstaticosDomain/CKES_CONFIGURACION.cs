namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_CONFIGURACION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(64)]
        public string ClaveEncriptacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ActivarAuditoria { get; set; }

        [StringLength(20)]
        public string ServidorTS { get; set; }

        [StringLength(10)]
        public string UsuarioTS { get; set; }

        [StringLength(30)]
        public string PasswordTS { get; set; }

        [StringLength(100)]
        public string DirectorioTS { get; set; }

        [StringLength(15)]
        public string NombreFicheroTS { get; set; }

        [StringLength(50)]
        public string ServidorLimites { get; set; }

        [StringLength(50)]
        public string BdLimites { get; set; }

        [StringLength(50)]
        public string OraBorradoPortfolios { get; set; }

        [StringLength(50)]
        public string OraBDColaterales { get; set; }

        [StringLength(50)]
        public string OraBDColateralesUser { get; set; }
    }
}
