namespace CKEstaticosDomain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CKES_MAQUINAS_SERVIDORES_LOG
    {
        [Key]
        [Column(Order = 0)]
        public int IdAccion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMaquinaCECA { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Accion { get; set; }

        [StringLength(50)]
        public string ValorInicial { get; set; }

        [StringLength(50)]
        public string ValorFinal { get; set; }

        public DateTime? FechaAccion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string IdDepartamento { get; set; }
    }
}
