namespace MoralesLarios.Data.IntegrationTests.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Errores> Errores { get; set; }
        public virtual DbSet<FacturaParametros> FacturaParametros { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<IdPedidoParametros> IdPedidoParametros { get; set; }
        public virtual DbSet<LineasPedidosCliente> LineasPedidosCliente { get; set; }
        public virtual DbSet<LineasPedidosProveedor> LineasPedidosProveedor { get; set; }
        public virtual DbSet<Opciones> Opciones { get; set; }
        public virtual DbSet<PedidiosProveedor> PedidiosProveedor { get; set; }
        public virtual DbSet<PedidosClientes> PedidosClientes { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.Familia)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Articulos>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.CIF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Errores>()
                .Property(e => e.ErrorDesc)
                .IsFixedLength();

            modelBuilder.Entity<LineasPedidosCliente>()
                .Property(e => e.DescuentoProveedor)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LineasPedidosCliente>()
                .Property(e => e.DescuentoCliente)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LineasPedidosCliente>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<LineasPedidosProveedor>()
                .Property(e => e.Descuento1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LineasPedidosProveedor>()
                .Property(e => e.Descuento2)
                .HasPrecision(4, 2);

            modelBuilder.Entity<LineasPedidosProveedor>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<PedidiosProveedor>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<PedidiosProveedor>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<PedidosClientes>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<PedidosClientes>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.CIF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.PedidiosProveedor)
                .WithRequired(e => e.Proveedor)
                .HasForeignKey(e => e.IdProveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.LineasPedidoClientes)
                .WithRequired(e => e.Proveedor)
                .HasForeignKey(e => e.IdProveedor)
                .WillCascadeOnDelete(false);



            modelBuilder.Entity<PedidiosProveedor>()
                .HasMany(e => e.LineasPedidoProveedor)
                .WithRequired(e => e.PedidoProveedor)
                .HasForeignKey(e => e.IdPedido)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<PedidosClientes>()
                .HasMany(e => e.LineasPedidoClientes)
                .WithRequired(e => e.PedidoCliente)
                .HasForeignKey(e => e.IdPedido)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Articulos>()
                .HasMany(e => e.LineasPedidosProveedores)
                .WithRequired(e => e.Articulo)
                .HasForeignKey(e => e.IdArticulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Articulos>()
                .HasMany(e => e.LineasPedidoClientes)
                .WithRequired(e => e.Articulo)
                .HasForeignKey(e => e.IdArticulo)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.PedidiosCliente)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Facturas)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.PedidosClientes)
                .WithOptional(e => e.Factura)
                .HasForeignKey(e => e.IdFra)
                .WillCascadeOnDelete(false);
        }
    }
}
