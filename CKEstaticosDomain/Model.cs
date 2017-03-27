namespace CKEstaticosDomain
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
        public virtual DbSet<ALGO_AJUSTES_MAPPINGS> ALGO_AJUSTES_MAPPINGS { get; set; }
        public virtual DbSet<ALGO_CARGA_PORTFOLIOS> ALGO_CARGA_PORTFOLIOS { get; set; }
        public virtual DbSet<ALGO_CARGA_SEGUIMIENTO> ALGO_CARGA_SEGUIMIENTO { get; set; }
        public virtual DbSet<Bands> Bands { get; set; }
        public virtual DbSet<CKAH_REG_TABLAS> CKAH_REG_TABLAS { get; set; }
        public virtual DbSet<CKES_ACTUALIZADOR_EQVOL> CKES_ACTUALIZADOR_EQVOL { get; set; }
        public virtual DbSet<CKES_APLICACIONES> CKES_APLICACIONES { get; set; }
        public virtual DbSet<CKES_APLICACIONES_MULTI> CKES_APLICACIONES_MULTI { get; set; }
        public virtual DbSet<CKES_AREAS> CKES_AREAS { get; set; }
        public virtual DbSet<CKES_BACKUPS> CKES_BACKUPS { get; set; }
        public virtual DbSet<CKES_BORRADO_PORTFOLIO> CKES_BORRADO_PORTFOLIO { get; set; }
        public virtual DbSet<CKES_DEPARTAMENTOS> CKES_DEPARTAMENTOS { get; set; }
        public virtual DbSet<CKES_DESCARGAS_FTP> CKES_DESCARGAS_FTP { get; set; }
        public virtual DbSet<CKES_ENTIDAD_AGRUPACION> CKES_ENTIDAD_AGRUPACION { get; set; }
        public virtual DbSet<CKES_ENTIDAD_APLICACION> CKES_ENTIDAD_APLICACION { get; set; }
        public virtual DbSet<CKES_ENTIDAD_APLICACION_MULTI> CKES_ENTIDAD_APLICACION_MULTI { get; set; }
        public virtual DbSet<CKES_ENTIDAD_DATOSENVIO> CKES_ENTIDAD_DATOSENVIO { get; set; }
        public virtual DbSet<CKES_ENTIDADES> CKES_ENTIDADES { get; set; }
        public virtual DbSet<CKES_ENTIDADES_CONTACTOS_TIPO_CONTACTO> CKES_ENTIDADES_CONTACTOS_TIPO_CONTACTO { get; set; }
        public virtual DbSet<CKES_ENTIDADES_TIPO_CONTACTO> CKES_ENTIDADES_TIPO_CONTACTO { get; set; }
        public virtual DbSet<CKES_GENERACION_PWD> CKES_GENERACION_PWD { get; set; }
        public virtual DbSet<CKES_GUARDIAS> CKES_GUARDIAS { get; set; }
        public virtual DbSet<CKES_GUARDIAS_AGRUPACIONES> CKES_GUARDIAS_AGRUPACIONES { get; set; }
        public virtual DbSet<CKES_GUARDIAS_INTERVENCIONES> CKES_GUARDIAS_INTERVENCIONES { get; set; }
        public virtual DbSet<CKES_GUARDIAS_INTERVENCIONES_TIPOS> CKES_GUARDIAS_INTERVENCIONES_TIPOS { get; set; }
        public virtual DbSet<CKES_INF_OB> CKES_INF_OB { get; set; }
        public virtual DbSet<CKES_INF_TS> CKES_INF_TS { get; set; }
        public virtual DbSet<CKES_INFORMESPLVISTAS> CKES_INFORMESPLVISTAS { get; set; }
        public virtual DbSet<CKES_LICENCIAS> CKES_LICENCIAS { get; set; }
        public virtual DbSet<CKES_LICENCIAS_ADAPTIV> CKES_LICENCIAS_ADAPTIV { get; set; }
        public virtual DbSet<CKES_LICENCIASCITRIX> CKES_LICENCIASCITRIX { get; set; }
        public virtual DbSet<CKES_LICENCIASCITRIX_USUARIOS> CKES_LICENCIASCITRIX_USUARIOS { get; set; }
        public virtual DbSet<CKES_LOG_SESIONES> CKES_LOG_SESIONES { get; set; }
        public virtual DbSet<CKES_LOG_TRAZAS> CKES_LOG_TRAZAS { get; set; }
        public virtual DbSet<CKES_MAQUINAS_CLIENTES> CKES_MAQUINAS_CLIENTES { get; set; }
        public virtual DbSet<CKES_MAQUINAS_SERVIDORES> CKES_MAQUINAS_SERVIDORES { get; set; }
        public virtual DbSet<CKES_NETTINGSTOBI> CKES_NETTINGSTOBI { get; set; }
        public virtual DbSet<CKES_NODOS> CKES_NODOS { get; set; }
        public virtual DbSet<CKES_NODOS_ROLES> CKES_NODOS_ROLES { get; set; }
        public virtual DbSet<CKES_POSITIONSTOBI> CKES_POSITIONSTOBI { get; set; }
        public virtual DbSet<CKES_RECALCULOPORTFOLIO> CKES_RECALCULOPORTFOLIO { get; set; }
        public virtual DbSet<CKES_REMOTEEXEC> CKES_REMOTEEXEC { get; set; }
        public virtual DbSet<CKES_ROLES_DESC> CKES_ROLES_DESC { get; set; }
        public virtual DbSet<CKES_ROLES_TABLAS> CKES_ROLES_TABLAS { get; set; }
        public virtual DbSet<CKES_RUTAS_FILECLEANER> CKES_RUTAS_FILECLEANER { get; set; }
        public virtual DbSet<CKES_SCRIPTS_SEG> CKES_SCRIPTS_SEG { get; set; }
        public virtual DbSet<CKES_SINCRONIZACION> CKES_SINCRONIZACION { get; set; }
        public virtual DbSet<CKES_SUBENTIDAD> CKES_SUBENTIDAD { get; set; }
        public virtual DbSet<CKES_TABLAS> CKES_TABLAS { get; set; }
        public virtual DbSet<CKES_UPDATEBOTICKET> CKES_UPDATEBOTICKET { get; set; }
        public virtual DbSet<CKES_USUARIOS> CKES_USUARIOS { get; set; }
        public virtual DbSet<CKES_USUARIOS_DEPARTAMENTOS> CKES_USUARIOS_DEPARTAMENTOS { get; set; }
        public virtual DbSet<CKES_USUARIOS_PANORAMA> CKES_USUARIOS_PANORAMA { get; set; }
        public virtual DbSet<CKES_USUARIOS_PANORAMA_HISTORICO> CKES_USUARIOS_PANORAMA_HISTORICO { get; set; }
        public virtual DbSet<CKES_VAR_SS_EXTRACT> CKES_VAR_SS_EXTRACT { get; set; }
        public virtual DbSet<CKES_VAR_SS_MAIN> CKES_VAR_SS_MAIN { get; set; }
        public virtual DbSet<CKES_VAR_SS_OWNER> CKES_VAR_SS_OWNER { get; set; }
        public virtual DbSet<CKES_VISTAS_LC_SEG> CKES_VISTAS_LC_SEG { get; set; }
        public virtual DbSet<CKET_PARAM_INFORMES> CKET_PARAM_INFORMES { get; set; }
        public virtual DbSet<CKET_PARAM_INFORMES_V2> CKET_PARAM_INFORMES_V2 { get; set; }
        public virtual DbSet<CKET_PARAM_PROPS> CKET_PARAM_PROPS { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<GEHD_INCIDENCIAS> GEHD_INCIDENCIAS { get; set; }
        public virtual DbSet<GEIN_ANEXOS> GEIN_ANEXOS { get; set; }
        public virtual DbSet<GEIN_BLOQUE> GEIN_BLOQUE { get; set; }
        public virtual DbSet<GEIN_CONCEPTO> GEIN_CONCEPTO { get; set; }
        public virtual DbSet<GEIN_CORTES_SERVICIO> GEIN_CORTES_SERVICIO { get; set; }
        public virtual DbSet<GEIN_ESTADO> GEIN_ESTADO { get; set; }
        public virtual DbSet<GEIN_ESTADOS_PROVEEDOR> GEIN_ESTADOS_PROVEEDOR { get; set; }
        public virtual DbSet<GEIN_ETIQUETAS> GEIN_ETIQUETAS { get; set; }
        public virtual DbSet<GEIN_PRIORIDAD> GEIN_PRIORIDAD { get; set; }
        public virtual DbSet<GEIN_PRODUCTOS> GEIN_PRODUCTOS { get; set; }
        public virtual DbSet<JOBS_CALENDARIO> JOBS_CALENDARIO { get; set; }
        public virtual DbSet<JOBS_DOCUMENTACION> JOBS_DOCUMENTACION { get; set; }
        public virtual DbSet<JOBS_EXPLOTACION> JOBS_EXPLOTACION { get; set; }
        public virtual DbSet<JOBS_EXPLOTACION_SEG> JOBS_EXPLOTACION_SEG { get; set; }
        public virtual DbSet<JOBS_GENERAL> JOBS_GENERAL { get; set; }
        public virtual DbSet<JOBS_QRY> JOBS_QRY { get; set; }
        public virtual DbSet<LAUD_TABLAS_AUDITORIA> LAUD_TABLAS_AUDITORIA { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<CKAH_FECHAS> CKAH_FECHAS { get; set; }
        public virtual DbSet<CKAH_FECHAS_HIS> CKAH_FECHAS_HIS { get; set; }
        public virtual DbSet<CKES_CONFIGURACION> CKES_CONFIGURACION { get; set; }
        public virtual DbSet<CKES_ENTIDADES_CONTACTOS> CKES_ENTIDADES_CONTACTOS { get; set; }
        public virtual DbSet<CKES_GUARDIAS_CONFIGURACION> CKES_GUARDIAS_CONFIGURACION { get; set; }
        public virtual DbSet<CKES_MAQUINAS_SERVIDORES_LOG> CKES_MAQUINAS_SERVIDORES_LOG { get; set; }
        public virtual DbSet<CKES_MAQUINAS_SERVIDORES_RETENCION> CKES_MAQUINAS_SERVIDORES_RETENCION { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALGO_CARGA_PORTFOLIOS>()
                .Property(e => e.Ejecutar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALGO_CARGA_PORTFOLIOS>()
                .Property(e => e.Fusionar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALGO_CARGA_SEGUIMIENTO>()
                .Property(e => e.IdTraza)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ALGO_CARGA_SEGUIMIENTO>()
                .Property(e => e.Resultado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKAH_REG_TABLAS>()
                .Property(e => e.NombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<CKAH_REG_TABLAS>()
                .Property(e => e.Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<CKAH_REG_TABLAS>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES>()
                .Property(e => e.PrefijoTabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES>()
                .Property(e => e.Version)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES_MULTI>()
                .Property(e => e.PrefijoTabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES_MULTI>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_APLICACIONES_MULTI>()
                .Property(e => e.Version)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_AREAS>()
                .Property(e => e.IdArea)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_BACKUPS>()
                .Property(e => e.IdCopiaSeguridad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_BACKUPS>()
                .Property(e => e.IdUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_BACKUPS>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_BACKUPS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_BORRADO_PORTFOLIO>()
                .Property(e => e.TipoTabla)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DEPARTAMENTOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DEPARTAMENTOS>()
                .Property(e => e.IdArea)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.SNameAplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.IdUsuarioPan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.FTPServidor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.FTPUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.FTPPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.NotificarDescarga)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.IncluirArchivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.OrdenEjecucion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_DESCARGAS_FTP>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_AGRUPACION>()
                .Property(e => e.IdAgrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_AGRUPACION>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.SNameAplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.IdUsuarioPan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.TipoEnvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.Encriptar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION>()
                .Property(e => e.Zipear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.SNameAplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.IdUsuarioPan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.TipoEnvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.Encriptar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.Zipear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.FTPServidor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.FTPUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.FTPPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.MailServidorSMTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.ErrorSinFilas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.ErrorConFilas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.LocalAnexarFecha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_APLICACION_MULTI>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.SNameAplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.IdUsuarioPan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.FTPServidor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.FTPUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.FTPPwd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.MailServidorSMTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.ErrorSinFilas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.ErrorConFilas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDAD_DATOSENVIO>()
                .Property(e => e.LocalAnexarFecha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES>()
                .Property(e => e.PrefijoVPD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES>()
                .Property(e => e.HabilitaSubentidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_TIPO_CONTACTO>()
                .Property(e => e.NombreTipo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_TIPO_CONTACTO>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_TIPO_CONTACTO>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GENERACION_PWD>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS>()
                .Property(e => e.idAgrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_AGRUPACIONES>()
                .Property(e => e.IdAgrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_AGRUPACIONES>()
                .Property(e => e.AnyoAsociado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_AGRUPACIONES>()
                .Property(e => e.MesAsociado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_AGRUPACIONES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_INTERVENCIONES>()
                .Property(e => e.IdAgrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_INTERVENCIONES>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_INTERVENCIONES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_INTERVENCIONES_TIPOS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_INTERVENCIONES_TIPOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INF_OB>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INF_OB>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INF_OB>()
                .Property(e => e.ESQUEMA)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INF_TS>()
                .Property(e => e.TABLESPACE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INFORMESPLVISTAS>()
                .Property(e => e.PortfolioId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_INFORMESPLVISTAS>()
                .Property(e => e.Ejecutar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIAS>()
                .Property(e => e.RenovacionAnual)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIAS>()
                .Property(e => e.Beneficiario)
                .IsFixedLength();

            modelBuilder.Entity<CKES_LICENCIAS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIAS_ADAPTIV>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIAS_ADAPTIV>()
                .Property(e => e.LicenciaAdaptiv)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIASCITRIX>()
                .Property(e => e.UsuarioCitrix)
                .IsFixedLength();

            modelBuilder.Entity<CKES_LICENCIASCITRIX>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIASCITRIX>()
                .Property(e => e.Agrupacion)
                .IsFixedLength();

            modelBuilder.Entity<CKES_LICENCIASCITRIX>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIASCITRIX_USUARIOS>()
                .Property(e => e.UsuarioCitrix)
                .IsFixedLength();

            modelBuilder.Entity<CKES_LICENCIASCITRIX_USUARIOS>()
                .Property(e => e.IdUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LICENCIASCITRIX_USUARIOS>()
                .Property(e => e.Procedencia)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LOG_SESIONES>()
                .Property(e => e.IdSesion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CKES_LOG_SESIONES>()
                .Property(e => e.IdUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LOG_SESIONES>()
                .Property(e => e.IdMaquina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LOG_SESIONES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LOG_TRAZAS>()
                .Property(e => e.IdTraza)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CKES_LOG_TRAZAS>()
                .Property(e => e.IdSesion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CKES_LOG_TRAZAS>()
                .Property(e => e.Sentencia)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_LOG_TRAZAS>()
                .Property(e => e.TipoSentencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.IdMaquinaCECA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.Fabricante)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.Modelo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.RAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.Procesador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_CLIENTES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES>()
                .Property(e => e.DirIPInterna)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES>()
                .Property(e => e.DirIPHidra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES>()
                .Property(e => e.Entorno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NETTINGSTOBI>()
                .Property(e => e.PortfolioId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NETTINGSTOBI>()
                .Property(e => e.Ejecutar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NODOS>()
                .Property(e => e.Nodo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NODOS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NODOS_ROLES>()
                .Property(e => e.Nodo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NODOS_ROLES>()
                .Property(e => e.IdRol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_NODOS_ROLES>()
                .Property(e => e.Acceso)
                .IsFixedLength();

            modelBuilder.Entity<CKES_POSITIONSTOBI>()
                .Property(e => e.PortfolioId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_POSITIONSTOBI>()
                .Property(e => e.Fecha)
                .IsFixedLength();

            modelBuilder.Entity<CKES_POSITIONSTOBI>()
                .Property(e => e.Ejecutar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RECALCULOPORTFOLIO>()
                .Property(e => e.PortfolioId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RECALCULOPORTFOLIO>()
                .Property(e => e.SaveResults)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RECALCULOPORTFOLIO>()
                .Property(e => e.Fecha)
                .IsFixedLength();

            modelBuilder.Entity<CKES_REMOTEEXEC>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ROLES_DESC>()
                .Property(e => e.IdRol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ROLES_TABLAS>()
                .Property(e => e.IdRol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ROLES_TABLAS>()
                .Property(e => e.NombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ROLES_TABLAS>()
                .Property(e => e.AccesoTabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RUTAS_FILECLEANER>()
                .Property(e => e.IdMaquinaCECA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RUTAS_FILECLEANER>()
                .Property(e => e.Extension)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RUTAS_FILECLEANER>()
                .Property(e => e.Subcarpetas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RUTAS_FILECLEANER>()
                .Property(e => e.ZipUnicoFichero)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_RUTAS_FILECLEANER>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_SCRIPTS_SEG>()
                .Property(e => e.IdScript)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CKES_SCRIPTS_SEG>()
                .Property(e => e.EnviarDescentralizadas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_SCRIPTS_SEG>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_SINCRONIZACION>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_SUBENTIDAD>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_TABLAS>()
                .Property(e => e.NombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_TABLAS>()
                .Property(e => e.GenerarScript)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_TABLAS>()
                .Property(e => e.IncluirFiltroVista)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_TABLAS>()
                .Property(e => e.NodoAsociado)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_UPDATEBOTICKET>()
                .Property(e => e.Activado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.IdUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.IdRol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.Telefono1)
                .IsFixedLength();

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.Telefono2)
                .IsFixedLength();

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.IdResponsable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.Activo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.IdMaquina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.RolAlgoConciliacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.RealizaGuardias)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.TelefonosGuardia)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS_DEPARTAMENTOS>()
                .Property(e => e.IdUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS_DEPARTAMENTOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS_PANORAMA>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_USUARIOS_PANORAMA_HISTORICO>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_VAR_SS_EXTRACT>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_VAR_SS_EXTRACT>()
                .Property(e => e.OrdenEjecucion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_VAR_SS_MAIN>()
                .Property(e => e.Ejecutar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_VISTAS_LC_SEG>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES>()
                .Property(e => e.IdUsuarioPan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES>()
                .Property(e => e.PortfolioID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES>()
                .Property(e => e.OrdenEjecucion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES_V2>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES_V2>()
                .Property(e => e.PortfolioID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_INFORMES_V2>()
                .Property(e => e.MDA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_PROPS>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CKET_PARAM_PROPS>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.IdIncidencia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.Prioridad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEHD_INCIDENCIAS>()
                .Property(e => e.ComputaEstadisticas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_ANEXOS>()
                .Property(e => e.IdAnexo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GEIN_ANEXOS>()
                .Property(e => e.Tabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_ANEXOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_BLOQUE>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_CONCEPTO>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_CORTES_SERVICIO>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_ESTADO>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_ESTADOS_PROVEEDOR>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_ETIQUETAS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GEIN_PRODUCTOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Lunes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Martes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Miercoles)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Jueves)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Viernes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Sabado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.Domingo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.FestivosEuropeos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.FestivosTarget)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.DiaMes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.UltimoDiaHabil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_CALENDARIO>()
                .Property(e => e.PrimerDiaHabil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_DOCUMENTACION>()
                .Property(e => e.ColorGrafico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_DOCUMENTACION>()
                .Property(e => e.JobHorario)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_DOCUMENTACION>()
                .Property(e => e.EncadenadoA)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_DOCUMENTACION>()
                .Property(e => e.TareaProgramadaCrear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_DOCUMENTACION>()
                .Property(e => e.TareaProgramadaDefValue)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_EXPLOTACION_SEG>()
                .Property(e => e.IdEjecucion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<JOBS_GENERAL>()
                .Property(e => e.EsJobsManager)
                .IsUnicode(false);

            modelBuilder.Entity<JOBS_GENERAL>()
                .Property(e => e.EjecutarEnFestivo)
                .IsUnicode(false);

            modelBuilder.Entity<LAUD_TABLAS_AUDITORIA>()
                .Property(e => e.Owner)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.ActivarAuditoria)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.ServidorTS)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.UsuarioTS)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.PasswordTS)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.DirectorioTS)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.NombreFicheroTS)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.ServidorLimites)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.BdLimites)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.OraBorradoPortfolios)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.OraBDColaterales)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_CONFIGURACION>()
                .Property(e => e.OraBDColateralesUser)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.IdEntidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.Telefono1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.Telefono2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.cargo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.CITRIX_Maquina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_ENTIDADES_CONTACTOS>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_CONFIGURACION>()
                .Property(e => e.DepartamentoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_CONFIGURACION>()
                .Property(e => e.HorarioGuardias)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_GUARDIAS_CONFIGURACION>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_LOG>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.ServidorOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.TipoArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.tiempoRetencion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.IdentificadorEnTSM)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CKES_MAQUINAS_SERVIDORES_RETENCION>()
                .Property(e => e.IdDepartamento)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
