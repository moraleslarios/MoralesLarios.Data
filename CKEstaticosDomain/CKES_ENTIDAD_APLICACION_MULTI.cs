namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_ENTIDAD_APLICACION_MULTI
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
        [StringLength(1)]
        public string TipoEnvio { get; set; }

        [Required]
        [StringLength(1)]
        public string Encriptar { get; set; }

        [Required]
        [StringLength(1)]
        public string Zipear { get; set; }

        [StringLength(32)]
        public string FTPServidor { get; set; }

        [StringLength(64)]
        public string FTPRuta { get; set; }

        [StringLength(12)]
        public string FTPUsuario { get; set; }

        [StringLength(32)]
        public string FTPPwd { get; set; }

        [StringLength(32)]
        public string MailServidorSMTP { get; set; }

        [StringLength(256)]
        public string MailDirecDestino { get; set; }

        [StringLength(32)]
        public string MailDirecOrigen { get; set; }

        [StringLength(64)]
        public string MailNombreOrigen { get; set; }

        [StringLength(1024)]
        public string MailSubject { get; set; }

        [Column(TypeName = "ntext")]
        public string MailBody { get; set; }

        [StringLength(1024)]
        public string LocalRuta { get; set; }

        [StringLength(50)]
        public string LocalNombre { get; set; }

        [StringLength(2)]
        public string ErrorSinFilas { get; set; }

        [StringLength(2)]
        public string ErrorConFilas { get; set; }

        public int? ErrorPrimeraLineaCheck { get; set; }

        [StringLength(256)]
        public string MailDirecDestinoError { get; set; }

        [StringLength(1024)]
        public string MailSubjectError { get; set; }

        [Column(TypeName = "ntext")]
        public string MailBodyError { get; set; }

        [StringLength(2)]
        public string LocalAnexarFecha { get; set; }

        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
