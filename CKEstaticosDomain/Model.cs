namespace DataDomain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }

        //public virtual DbSet<dtproperties> dtproperties { get; set; }




        public virtual DbSet<GEIN_CORTES_SERVICIO> GEIN_CORTES_SERVICIO { get; set; }






        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
