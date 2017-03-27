namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_DESCARGAS_FTP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string IdEntidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SNameAplicacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string IdUsuarioPan { get; set; }

        [Required]
        [StringLength(32)]
        public string FTPServidor { get; set; }

        [Required]
        [StringLength(64)]
        public string FTPRuta { get; set; }

        [Required]
        [StringLength(12)]
        public string FTPUsuario { get; set; }

        [Required]
        [StringLength(32)]
        public string FTPPwd { get; set; }

        [Required]
        [StringLength(256)]
        public string RutaDestino { get; set; }

        [Required]
        [StringLength(2)]
        public string NotificarDescarga { get; set; }

        [Required]
        [StringLength(2)]
        public string IncluirArchivo { get; set; }

        [Required]
        [StringLength(4)]
        public string OrdenEjecucion { get; set; }

        [Required]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
