using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestServiceSabio.Entities
{
    public partial class SabioDbContext : DbContext
    {
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Alertas> Alertas { get; set; }
        public virtual DbSet<AlicuotasIbr> AlicuotasIbr { get; set; }
        public virtual DbSet<Arancelesxrubro> Arancelesxrubro { get; set; }
        public virtual DbSet<Arbol> Arbol { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<ArticulosXProveedor> ArticulosXProveedor { get; set; }
        public virtual DbSet<Asientos> Asientos { get; set; }
        public virtual DbSet<Asientosmodelos> Asientosmodelos { get; set; }
        public virtual DbSet<AsignacionManodeobra> AsignacionManodeobra { get; set; }
        public virtual DbSet<Asixcaja> Asixcaja { get; set; }
        public virtual DbSet<Asixcancelatorios> Asixcancelatorios { get; set; }
        public virtual DbSet<Asixmovban> Asixmovban { get; set; }
        public virtual DbSet<Autoasiento> Autoasiento { get; set; }
        public virtual DbSet<Avancexproyecto> Avancexproyecto { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Billetes> Billetes { get; set; }
        public virtual DbSet<Bultos> Bultos { get; set; }
        public virtual DbSet<Cajas> Cajas { get; set; }
        public virtual DbSet<Cancelatorios> Cancelatorios { get; set; }
        public virtual DbSet<CashFlow> CashFlow { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CentrosCosto> CentrosCosto { get; set; }
        public virtual DbSet<Chequeras> Chequeras { get; set; }
        public virtual DbSet<Cheques3> Cheques3 { get; set; }
        public virtual DbSet<Chequespro> Chequespro { get; set; }
        public virtual DbSet<Chkcalidad> Chkcalidad { get; set; }
        public virtual DbSet<Chkrecepcion> Chkrecepcion { get; set; }
        public virtual DbSet<Choferes> Choferes { get; set; }
        public virtual DbSet<Choxtra> Choxtra { get; set; }
        public virtual DbSet<Codbancos> Codbancos { get; set; }
        public virtual DbSet<CodigosCash> CodigosCash { get; set; }
        public virtual DbSet<CodigosRetenciones> CodigosRetenciones { get; set; }
        public virtual DbSet<ColectorDeStock> ColectorDeStock { get; set; }
        public virtual DbSet<ComposicionArt> ComposicionArt { get; set; }
        public virtual DbSet<Comprobantes> Comprobantes { get; set; }
        public virtual DbSet<Comproxtal> Comproxtal { get; set; }
        public virtual DbSet<Comunicaciones> Comunicaciones { get; set; }
        public virtual DbSet<ConceptosCash> ConceptosCash { get; set; }
        public virtual DbSet<Conceptosor> Conceptosor { get; set; }
        public virtual DbSet<Congan> Congan { get; set; }
        public virtual DbSet<Contratos> Contratos { get; set; }
        public virtual DbSet<Cotizaciones> Cotizaciones { get; set; }
        public virtual DbSet<Ctacaja> Ctacaja { get; set; }
        public virtual DbSet<Cuebancos> Cuebancos { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<Cupones> Cupones { get; set; }
        public virtual DbSet<Currentpc> Currentpc { get; set; }
        public virtual DbSet<Depositos> Depositos { get; set; }
        public virtual DbSet<DescuentosXVta> DescuentosXVta { get; set; }
        public virtual DbSet<Despachos> Despachos { get; set; }
        public virtual DbSet<DestinosTran> DestinosTran { get; set; }
        public virtual DbSet<Detaplicaciones> Detaplicaciones { get; set; }
        public virtual DbSet<Detasientos> Detasientos { get; set; }
        public virtual DbSet<Detasientosmodelos> Detasientosmodelos { get; set; }
        public virtual DbSet<Detbultos> Detbultos { get; set; }
        public virtual DbSet<Detcalidador> Detcalidador { get; set; }
        public virtual DbSet<Detcancelatorios> Detcancelatorios { get; set; }
        public virtual DbSet<DetColector> DetColector { get; set; }
        public virtual DbSet<Detcompxnoconart> Detcompxnoconart { get; set; }
        public virtual DbSet<Detcompxstk> Detcompxstk { get; set; }
        public virtual DbSet<Detconceptosor> Detconceptosor { get; set; }
        public virtual DbSet<DetContratos> DetContratos { get; set; }
        public virtual DbSet<Detconxnoconxart> Detconxnoconxart { get; set; }
        public virtual DbSet<Detencuestaor> Detencuestaor { get; set; }
        public virtual DbSet<Detestadosor> Detestadosor { get; set; }
        public virtual DbSet<Detestilosimpresion> Detestilosimpresion { get; set; }
        public virtual DbSet<Detfallasor> Detfallasor { get; set; }
        public virtual DbSet<DetHojaRuta> DetHojaRuta { get; set; }
        public virtual DbSet<Detinformes> Detinformes { get; set; }
        public virtual DbSet<DetLiquidaciones> DetLiquidaciones { get; set; }
        public virtual DbSet<DetLiquidacionesAnul> DetLiquidacionesAnul { get; set; }
        public virtual DbSet<DetLiquidacionesXMonto> DetLiquidacionesXMonto { get; set; }
        public virtual DbSet<DetLogrepartos> DetLogrepartos { get; set; }
        public virtual DbSet<DetModeloAceite> DetModeloAceite { get; set; }
        public virtual DbSet<DetMovArticulos> DetMovArticulos { get; set; }
        public virtual DbSet<Detmovcontables> Detmovcontables { get; set; }
        public virtual DbSet<Detmovnoconart> Detmovnoconart { get; set; }
        public virtual DbSet<Detoferta> Detoferta { get; set; }
        public virtual DbSet<Detpagoscuotas> Detpagoscuotas { get; set; }
        public virtual DbSet<Detplancuotas> Detplancuotas { get; set; }
        public virtual DbSet<Detplanesfac> Detplanesfac { get; set; }
        public virtual DbSet<DetplanesPro> DetplanesPro { get; set; }
        public virtual DbSet<Detplanesxnocon> Detplanesxnocon { get; set; }
        public virtual DbSet<Detplanesxstk> Detplanesxstk { get; set; }
        public virtual DbSet<DetPrecuo> DetPrecuo { get; set; }
        public virtual DbSet<DetPresupuestosXTareas> DetPresupuestosXTareas { get; set; }
        public virtual DbSet<DetPreXMat> DetPreXMat { get; set; }
        public virtual DbSet<Detprorrateos> Detprorrateos { get; set; }
        public virtual DbSet<Detrecepcionor> Detrecepcionor { get; set; }
        public virtual DbSet<Detrepuestosor> Detrepuestosor { get; set; }
        public virtual DbSet<Detretdinamicas> Detretdinamicas { get; set; }
        public virtual DbSet<Detretenciones> Detretenciones { get; set; }
        public virtual DbSet<Detretmov> Detretmov { get; set; }
        public virtual DbSet<DetTareas> DetTareas { get; set; }
        public virtual DbSet<DetTiposContratos> DetTiposContratos { get; set; }
        public virtual DbSet<Dettiposlayout> Dettiposlayout { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Empresaorigen> Empresaorigen { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Encuestaor> Encuestaor { get; set; }
        public virtual DbSet<Equivalencias> Equivalencias { get; set; }
        public virtual DbSet<Equixmodelo> Equixmodelo { get; set; }
        public virtual DbSet<Estadoscheques> Estadoscheques { get; set; }
        public virtual DbSet<EstadosContratos> EstadosContratos { get; set; }
        public virtual DbSet<Estadosdespachos> Estadosdespachos { get; set; }
        public virtual DbSet<EstadosHojaRuta> EstadosHojaRuta { get; set; }
        public virtual DbSet<EstadosLogrepartos> EstadosLogrepartos { get; set; }
        public virtual DbSet<Estadosnocon> Estadosnocon { get; set; }
        public virtual DbSet<Estadosor> Estadosor { get; set; }
        public virtual DbSet<EstadosPlanesPro> EstadosPlanesPro { get; set; }
        public virtual DbSet<EstadosPre> EstadosPre { get; set; }
        public virtual DbSet<EstadosProyectos> EstadosProyectos { get; set; }
        public virtual DbSet<EstadosRelaciones> EstadosRelaciones { get; set; }
        public virtual DbSet<Estadosrma> Estadosrma { get; set; }
        public virtual DbSet<Estadosrmapro> Estadosrmapro { get; set; }
        public virtual DbSet<EstadosTar> EstadosTar { get; set; }
        public virtual DbSet<EstadosTran> EstadosTran { get; set; }
        public virtual DbSet<Estiloimpresion> Estiloimpresion { get; set; }
        public virtual DbSet<EtapasFac> EtapasFac { get; set; }
        public virtual DbSet<Fallas> Fallas { get; set; }
        public virtual DbSet<FCanales> FCanales { get; set; }
        public virtual DbSet<FClientes> FClientes { get; set; }
        public virtual DbSet<FListas> FListas { get; set; }
        public virtual DbSet<Forpagos> Forpagos { get; set; }
        public virtual DbSet<FPreciosXLista> FPreciosXLista { get; set; }
        public virtual DbSet<GrupoAceites> GrupoAceites { get; set; }
        public virtual DbSet<GrupoArt> GrupoArt { get; set; }
        public virtual DbSet<GrupoCash> GrupoCash { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<HojasRuta> HojasRuta { get; set; }
        public virtual DbSet<Horas> Horas { get; set; }
        public virtual DbSet<Identificadores> Identificadores { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<ImgArt> ImgArt { get; set; }
        public virtual DbSet<ImgCuentas> ImgCuentas { get; set; }
        public virtual DbSet<ImgMovconta> ImgMovconta { get; set; }
        public virtual DbSet<ImgMovnoconta> ImgMovnoconta { get; set; }
        public virtual DbSet<Imputaciones> Imputaciones { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<Intellireport> Intellireport { get; set; }
        public virtual DbSet<Internacional> Internacional { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Letras> Letras { get; set; }
        public virtual DbSet<Listaprecios> Listaprecios { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Logrepartos> Logrepartos { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<LugarCarga> LugarCarga { get; set; }
        public virtual DbSet<Maquinas> Maquinas { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Materiales> Materiales { get; set; }
        public virtual DbSet<MaximosXDepositos> MaximosXDepositos { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModeloAceite> ModeloAceite { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<MontosXCuenta> MontosXCuenta { get; set; }
        public virtual DbSet<Motivos> Motivos { get; set; }
        public virtual DbSet<MovArticulos> MovArticulos { get; set; }
        public virtual DbSet<Movbancos> Movbancos { get; set; }
        public virtual DbSet<Movcajas> Movcajas { get; set; }
        public virtual DbSet<Movcheques3> Movcheques3 { get; set; }
        public virtual DbSet<Movchequespro> Movchequespro { get; set; }
        public virtual DbSet<Movcontables> Movcontables { get; set; }
        public virtual DbSet<Movcupones> Movcupones { get; set; }
        public virtual DbSet<Movestadosdes> Movestadosdes { get; set; }
        public virtual DbSet<MovManodeobra> MovManodeobra { get; set; }
        public virtual DbSet<MovMateriales> MovMateriales { get; set; }
        public virtual DbSet<Movnocontables> Movnocontables { get; set; }
        public virtual DbSet<Movobras> Movobras { get; set; }
        public virtual DbSet<Movproyectoscontables> Movproyectoscontables { get; set; }
        public virtual DbSet<Movproyectosnocontables> Movproyectosnocontables { get; set; }
        public virtual DbSet<MovRelaciones> MovRelaciones { get; set; }
        public virtual DbSet<Movrma> Movrma { get; set; }
        public virtual DbSet<Movrmapro> Movrmapro { get; set; }
        public virtual DbSet<Movserialesart> Movserialesart { get; set; }
        public virtual DbSet<Movserialescontables> Movserialescontables { get; set; }
        public virtual DbSet<Movserialesnocon> Movserialesnocon { get; set; }
        public virtual DbSet<Movtransporte> Movtransporte { get; set; }
        public virtual DbSet<Movventas> Movventas { get; set; }
        public virtual DbSet<Negociaciones> Negociaciones { get; set; }
        public virtual DbSet<NegoContables> NegoContables { get; set; }
        public virtual DbSet<NegoNocon> NegoNocon { get; set; }
        public virtual DbSet<Noconxcon> Noconxcon { get; set; }
        public virtual DbSet<Nrosdespachos> Nrosdespachos { get; set; }
        public virtual DbSet<Obras> Obras { get; set; }
        public virtual DbSet<Oferta> Oferta { get; set; }
        public virtual DbSet<OrdenReparacion> OrdenReparacion { get; set; }
        public virtual DbSet<Orientaciones> Orientaciones { get; set; }
        public virtual DbSet<Origenes> Origenes { get; set; }
        public virtual DbSet<OtLub> OtLub { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Pergrupo> Pergrupo { get; set; }
        public virtual DbSet<Perusuarios> Perusuarios { get; set; }
        public virtual DbSet<Pesajes> Pesajes { get; set; }
        public virtual DbSet<Picking> Picking { get; set; }
        public virtual DbSet<PickingConta> PickingConta { get; set; }
        public virtual DbSet<PickingEstados> PickingEstados { get; set; }
        public virtual DbSet<PickingNocon> PickingNocon { get; set; }
        public virtual DbSet<PickingUser> PickingUser { get; set; }
        public virtual DbSet<Plancomision> Plancomision { get; set; }
        public virtual DbSet<Plancuentas> Plancuentas { get; set; }
        public virtual DbSet<Plancuotas> Plancuotas { get; set; }
        public virtual DbSet<PlanesPro> PlanesPro { get; set; }
        public virtual DbSet<Plantilla> Plantilla { get; set; }
        public virtual DbSet<Plantran> Plantran { get; set; }
        public virtual DbSet<PreciosXListapre> PreciosXListapre { get; set; }
        public virtual DbSet<Presentaciones> Presentaciones { get; set; }
        public virtual DbSet<PresupCtas> PresupCtas { get; set; }
        public virtual DbSet<Presupuestos> Presupuestos { get; set; }
        public virtual DbSet<ProcesosArt> ProcesosArt { get; set; }
        public virtual DbSet<Profesionales> Profesionales { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<Proyectosobras> Proyectosobras { get; set; }
        public virtual DbSet<Reggan> Reggan { get; set; }
        public virtual DbSet<Regibr> Regibr { get; set; }
        public virtual DbSet<Regiva> Regiva { get; set; }
        public virtual DbSet<Reglascompro> Reglascompro { get; set; }
        public virtual DbSet<Reportes> Reportes { get; set; }
        public virtual DbSet<ResponsablesRelaciones> ResponsablesRelaciones { get; set; }
        public virtual DbSet<Rma> Rma { get; set; }
        public virtual DbSet<Rubros> Rubros { get; set; }
        public virtual DbSet<RubrosArt> RubrosArt { get; set; }
        public virtual DbSet<Sectores> Sectores { get; set; }
        public virtual DbSet<Seguimientoor> Seguimientoor { get; set; }
        public virtual DbSet<Seriales> Seriales { get; set; }
        public virtual DbSet<StockDeMateriales> StockDeMateriales { get; set; }
        public virtual DbSet<Subproductos> Subproductos { get; set; }
        public virtual DbSet<SubrubrosArt> SubrubrosArt { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<TablasCompro> TablasCompro { get; set; }
        public virtual DbSet<Talonarios> Talonarios { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }
        public virtual DbSet<Tarjetas> Tarjetas { get; set; }
        public virtual DbSet<TblComproIva> TblComproIva { get; set; }
        public virtual DbSet<Tecnicosor> Tecnicosor { get; set; }
        public virtual DbSet<Temas> Temas { get; set; }
        public virtual DbSet<Tercerizacionesor> Tercerizacionesor { get; set; }
        public virtual DbSet<Tipmon> Tipmon { get; set; }
        public virtual DbSet<Tipoasientos> Tipoasientos { get; set; }
        public virtual DbSet<TipoCash> TipoCash { get; set; }
        public virtual DbSet<Tipochequeras> Tipochequeras { get; set; }
        public virtual DbSet<Tipocom> Tipocom { get; set; }
        public virtual DbSet<Tipocuebanco> Tipocuebanco { get; set; }
        public virtual DbSet<Tipocuenta> Tipocuenta { get; set; }
        public virtual DbSet<TipoHoja> TipoHoja { get; set; }
        public virtual DbSet<Tipoimagenes> Tipoimagenes { get; set; }
        public virtual DbSet<Tipoimpresion> Tipoimpresion { get; set; }
        public virtual DbSet<Tipomaquinas> Tipomaquinas { get; set; }
        public virtual DbSet<Tipomensajes> Tipomensajes { get; set; }
        public virtual DbSet<Tipomonedas> Tipomonedas { get; set; }
        public virtual DbSet<Tipomov> Tipomov { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<Tipoplancuenta> Tipoplancuenta { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<TipoRelaciones> TipoRelaciones { get; set; }
        public virtual DbSet<Tiposaranceles> Tiposaranceles { get; set; }
        public virtual DbSet<Tiposcodbarra> Tiposcodbarra { get; set; }
        public virtual DbSet<Tiposcodret> Tiposcodret { get; set; }
        public virtual DbSet<TiposContratos> TiposContratos { get; set; }
        public virtual DbSet<Tiposlayout> Tiposlayout { get; set; }
        public virtual DbSet<TiposProyectos> TiposProyectos { get; set; }
        public virtual DbSet<TipoTarjeta> TipoTarjeta { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<TransCisterna> TransCisterna { get; set; }
        public virtual DbSet<TransCombustible> TransCombustible { get; set; }
        public virtual DbSet<TransDistancias> TransDistancias { get; set; }
        public virtual DbSet<TransEstados> TransEstados { get; set; }
        public virtual DbSet<TransIncoterms> TransIncoterms { get; set; }
        public virtual DbSet<TransOrdenes> TransOrdenes { get; set; }
        public virtual DbSet<TransOriDes> TransOriDes { get; set; }
        public virtual DbSet<Transportes> Transportes { get; set; }
        public virtual DbSet<TransRemolque> TransRemolque { get; set; }
        public virtual DbSet<TransSurtidor> TransSurtidor { get; set; }
        public virtual DbSet<TransTipoDoc> TransTipoDoc { get; set; }
        public virtual DbSet<TransVencXChofer> TransVencXChofer { get; set; }
        public virtual DbSet<TransVencXRemolque> TransVencXRemolque { get; set; }
        public virtual DbSet<TransVencXVehiculo> TransVencXVehiculo { get; set; }
        public virtual DbSet<TurnosLub> TurnosLub { get; set; }
        public virtual DbSet<UbicacionesArt> UbicacionesArt { get; set; }
        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<Unidadnegocio> Unidadnegocio { get; set; }
        public virtual DbSet<Usecase> Usecase { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Usuxgru> Usuxgru { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<Vehxtra> Vehxtra { get; set; }
        public virtual DbSet<VencimientosXVta> VencimientosXVta { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
        public virtual DbSet<Zonas> Zonas { get; set; }

        // Unable to generate entity type for table 'GANESC'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseFirebird(@"User=SYSDBA;Password=masterkey;Database=C:/GOLDEN_CL.FDB;DataSource=127.0.0.1;Port=3050;Dialect=3;Charset=UTF8;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Alertas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasDefaultValueSql("DEFAULT 'NOW'");

                entity.Property(e => e.Hora).HasDefaultValueSql("DEFAULT 'NOW'");
            });

            modelBuilder.Entity<AlicuotasIbr>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Arancelesxrubro>(entity =>
            {
                entity.HasKey(e => new { e.Tipoar, e.Rubro });
            });

            modelBuilder.Entity<Arbol>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Oculta).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Calcan).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Conser).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Escomp).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Muelis).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Muestk).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Presen).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<ArticulosXProveedor>(entity =>
            {
                entity.HasKey(e => new { e.Articu, e.Provee, e.Proces });

                entity.Property(e => e.Proces).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Asientos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Oculta).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Presup).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Asientosmodelos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsignacionManodeobra>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Asixcaja>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Nromov });

                entity.HasOne(d => d.NromovNavigation)
                    .WithMany(p => p.Asixcaja)
                    .HasForeignKey(d => d.Nromov)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIXCAJA_NROMOV");
            });

            modelBuilder.Entity<Asixcancelatorios>(entity =>
            {
                entity.HasKey(e => new { e.Numcan, e.Numasi });
            });

            modelBuilder.Entity<Asixmovban>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Movban, e.Asiban, e.Regban });
            });

            modelBuilder.Entity<Autoasiento>(entity =>
            {
                entity.HasKey(e => new { e.Unineg, e.Compro, e.Codimp });

                entity.Property(e => e.Defect).HasDefaultValueSql("DEFAULT 0");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Autoasiento)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AUTOASIENTO_CUENTA");
            });

            modelBuilder.Entity<Avancexproyecto>(entity =>
            {
                entity.HasKey(e => new { e.Proyec, e.Codart });
            });

            modelBuilder.Entity<Bancos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Billetes>(entity =>
            {
                entity.HasKey(e => new { e.Caja, e.Tipo });
            });

            modelBuilder.Entity<Bultos>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cajas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cancelatorios>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<CashFlow>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<CentrosCosto>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Deshab).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Unineg).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Chequeras>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cheques3>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Docume).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Noalao).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Tercer).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Chequespro>(entity =>
            {
                entity.HasKey(e => new { e.Cheque, e.Numero });

                entity.Property(e => e.Noalao).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Chkcalidad>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Chkrecepcion>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Choferes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Legajo).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<Choxtra>(entity =>
            {
                entity.HasKey(e => new { e.Numtra, e.Numcho });
            });

            modelBuilder.Entity<Codbancos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Afeiva).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Contra).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Libiva).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Percep).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Sistem).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Codbancos)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CODBANCOS_CUENTA");
            });

            modelBuilder.Entity<CodigosCash>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<CodigosRetenciones>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<ColectorDeStock>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<ComposicionArt>(entity =>
            {
                entity.HasKey(e => new { e.Codart, e.Numpro, e.Codins });

                entity.Property(e => e.Opcion).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Sumpre).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Comprobantes>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Aferea).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Afesal).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Afestk).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Comproxtal>(entity =>
            {
                entity.HasKey(e => new { e.Compro, e.Talona });
            });

            modelBuilder.Entity<Comunicaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Leido).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<ConceptosCash>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.ConceptosCash)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONCEPTO_REFERENCE_CODIGOS_");
            });

            modelBuilder.Entity<Conceptosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Congan>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Adjudi).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Autpla).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Conyug).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Debita).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Scorin).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Tarjet).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Cotizaciones>(entity =>
            {
                entity.HasKey(e => new { e.Moneda, e.Fecha });
            });

            modelBuilder.Entity<Ctacaja>(entity =>
            {
                entity.HasKey(e => new { e.Ctacaj, e.Caja });
            });

            modelBuilder.Entity<Cuebancos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Deshab).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Cuebancos)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUEBANCOS_CUENTA");
            });

            modelBuilder.Entity<Cuentas>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Boole1).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Boole2).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Cuenta).HasDefaultValueSql("DEFAULT 100000000000");

                entity.Property(e => e.Habili).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Moneda).HasDefaultValueSql("DEFAULT 1");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Cuentas)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUENTAS_CUENTA");
            });

            modelBuilder.Entity<Cupones>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Currentpc>(entity =>
            {
                entity.HasKey(e => new { e.Macadd, e.Nombre });
            });

            modelBuilder.Entity<Depositos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Numsuc).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<DescuentosXVta>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Despachos>(entity =>
            {
                entity.Property(e => e.Despac).ValueGeneratedNever();

                entity.Property(e => e.Paisor).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<DestinosTran>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detaplicaciones>(entity =>
            {
                entity.HasKey(e => new { e.Origen, e.Destin });
            });

            modelBuilder.Entity<Detasientos>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Reglon });

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Detasientos)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETASIENTOS_CUENTA");

                entity.HasOne(d => d.NumeroNavigation)
                    .WithMany(p => p.Detasientos)
                    .HasForeignKey(d => d.Numero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETASIENTOS_NUMERO");
            });

            modelBuilder.Entity<Detasientosmodelos>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Reglon });

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Detasientosmodelos)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETASIENTOSMODELOS_CUENTA");

                entity.HasOne(d => d.NumeroNavigation)
                    .WithMany(p => p.Detasientosmodelos)
                    .HasForeignKey(d => d.Numero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETASIENTOSMODELOS_NUMERO");
            });

            modelBuilder.Entity<Detbultos>(entity =>
            {
                entity.HasKey(e => new { e.Numdet, e.Numbul });
            });

            modelBuilder.Entity<Detcalidador>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detcancelatorios>(entity =>
            {
                entity.HasKey(e => new { e.Numint, e.Origen, e.Destin });

                entity.HasOne(d => d.NumintNavigation)
                    .WithMany(p => p.Detcancelatorios)
                    .HasForeignKey(d => d.Numint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETCANCELATORIOS_NUMINT");

                entity.HasOne(d => d.Detaplicaciones)
                    .WithMany(p => p.Detcancelatorios)
                    .HasForeignKey(d => new { d.Origen, d.Destin })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETCANCELATORIOS_APLICA");
            });

            modelBuilder.Entity<DetColector>(entity =>
            {
                entity.HasKey(e => new { e.Colect, e.Numero });
            });

            modelBuilder.Entity<Detcompxnoconart>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detcompxstk>(entity =>
            {
                entity.HasKey(e => new { e.Detcom, e.Detstk });
            });

            modelBuilder.Entity<Detconceptosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<DetContratos>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detconxnoconxart>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Reglon, e.Numint });

                entity.HasOne(d => d.NumintNavigation)
                    .WithMany(p => p.Detconxnoconxart)
                    .HasForeignKey(d => d.Numint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETCONXN_NUMINT");

                entity.HasOne(d => d.Detmovcontables)
                    .WithMany(p => p.Detconxnoconxart)
                    .HasForeignKey(d => new { d.Asient, d.Reglon })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETCONXN_ASIENT");
            });

            modelBuilder.Entity<Detencuestaor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detestadosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detestilosimpresion>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detfallasor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<DetHojaRuta>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detinformes>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Detinformes)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETINFORMES_CUENTA");
            });

            modelBuilder.Entity<DetLiquidaciones>(entity =>
            {
                entity.HasKey(e => new { e.Detrem, e.Asient, e.Reglon, e.Comliq });

                entity.HasOne(d => d.Detmovcontables)
                    .WithMany(p => p.DetLiquidaciones)
                    .HasForeignKey(d => new { d.Asient, d.Reglon })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_LIQUIDACIONES_ASIREG");
            });

            modelBuilder.Entity<DetLiquidacionesAnul>(entity =>
            {
                entity.HasKey(e => new { e.Detrem, e.Comliq });
            });

            modelBuilder.Entity<DetLiquidacionesXMonto>(entity =>
            {
                entity.HasKey(e => new { e.Detrem, e.Asient, e.Reglon, e.Comliq });

                entity.HasOne(d => d.Detmovcontables)
                    .WithMany(p => p.DetLiquidacionesXMonto)
                    .HasForeignKey(d => new { d.Asient, d.Reglon })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_LIQUI_X_MONTO_ASIREG");
            });

            modelBuilder.Entity<DetLogrepartos>(entity =>
            {
                entity.HasKey(e => new { e.Idpedi, e.Numrto });
            });

            modelBuilder.Entity<DetModeloAceite>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Nummod });
            });

            modelBuilder.Entity<DetMovArticulos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.HasOne(d => d.NrointNavigation)
                    .WithMany(p => p.DetMovArticulos)
                    .HasForeignKey(d => d.Nroint)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DET_MOV_REFERENCE_MOV_ART");
            });

            modelBuilder.Entity<Detmovcontables>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Reglon });

                entity.Property(e => e.Lispre).HasDefaultValueSql("DEFAULT 1");

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Detmovcontables)
                    .HasForeignKey(d => d.Asient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETMOVCONTABLES_ASIENT");
            });

            modelBuilder.Entity<Detmovnoconart>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Eshijo).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Lispre).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Detoferta>(entity =>
            {
                entity.HasKey(e => new { e.Numint, e.Numofe });
            });

            modelBuilder.Entity<Detpagoscuotas>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Detpagoscuotas)
                    .HasForeignKey(d => d.Asient)
                    .HasConstraintName("FK_DETPAGOSCUOTAS_ASIENT");
            });

            modelBuilder.Entity<Detplancuotas>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detplanesfac>(entity =>
            {
                entity.HasKey(e => new { e.Ctacte, e.Codart, e.Concep });
            });

            modelBuilder.Entity<DetplanesPro>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detplanesxnocon>(entity =>
            {
                entity.HasKey(e => new { e.Detpla, e.Detnoc });
            });

            modelBuilder.Entity<Detplanesxstk>(entity =>
            {
                entity.HasKey(e => new { e.Detpla, e.Detstk });
            });

            modelBuilder.Entity<DetPrecuo>(entity =>
            {
                entity.HasKey(e => new { e.Presen, e.Asicuo });
            });

            modelBuilder.Entity<DetPresupuestosXTareas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<DetPreXMat>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detprorrateos>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Detprorrateos)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DETPRORRATEOS_CUENTA");
            });

            modelBuilder.Entity<Detrecepcionor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detrepuestosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Detretdinamicas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Imprim).HasDefaultValueSql("DEFAULT 0");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Detretdinamicas)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETRETDI_REFERENCE_CODIGOS_");
            });

            modelBuilder.Entity<Detretenciones>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Detretenciones)
                    .HasForeignKey(d => d.Asient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETRETEN_REFERENCE_MOVCONTA");
            });

            modelBuilder.Entity<Detretmov>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Imprim).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.Valor).HasDefaultValueSql("DEFAULT 0");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Detretmov)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETRETMO_REFERENCE_CODRET");
            });

            modelBuilder.Entity<DetTareas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<DetTiposContratos>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Dettiposlayout>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Empresaorigen>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Encuestaor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Equivalencias>(entity =>
            {
                entity.HasKey(e => new { e.Idgrup, e.Codigo });
            });

            modelBuilder.Entity<Equixmodelo>(entity =>
            {
                entity.HasKey(e => new { e.Grupo, e.Modelo });
            });

            modelBuilder.Entity<Estadoscheques>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosContratos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estadosdespachos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosHojaRuta>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosLogrepartos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estadosnocon>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estadosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosPlanesPro>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosPre>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosProyectos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosRelaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estadosrma>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estadosrmapro>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosTar>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<EstadosTran>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Estiloimpresion>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Genret).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Tipcom)
                    .HasDefaultValueSql("DEFAULT 1")
                    .HasAnnotation("Description", "LBL:Tipo Com.");

                entity.Property(e => e.Tipimp).HasAnnotation("Description", "LBL:Tipo Imp.");
            });

            modelBuilder.Entity<EtapasFac>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Fallas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<FCanales>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<FClientes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<FListas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Forpagos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<FPreciosXLista>(entity =>
            {
                entity.HasKey(e => new { e.Canal, e.Lista, e.Codart, e.Fecvig, e.Client });
            });

            modelBuilder.Entity<GrupoAceites>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<GrupoArt>(entity =>
            {
                entity.HasKey(e => new { e.Padre, e.Hijo });
            });

            modelBuilder.Entity<GrupoCash>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<HojasRuta>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Horas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Identificadores>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Imagenes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<ImgArt>(entity =>
            {
                entity.HasKey(e => new { e.Codart, e.Imagen });
            });

            modelBuilder.Entity<ImgCuentas>(entity =>
            {
                entity.HasKey(e => new { e.Cuenta, e.Imagen });
            });

            modelBuilder.Entity<ImgMovconta>(entity =>
            {
                entity.HasKey(e => new { e.Conta, e.Imagen });
            });

            modelBuilder.Entity<ImgMovnoconta>(entity =>
            {
                entity.HasKey(e => new { e.Nconta, e.Imagen });
            });

            modelBuilder.Entity<Imputaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Informes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Intellireport>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Internacional>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Pais });
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Letras>(entity =>
            {
                entity.HasKey(e => new { e.Emite, e.Recibe });
            });

            modelBuilder.Entity<Listaprecios>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Facsub).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Localidades>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Logrepartos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<LugarCarga>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Maquinas>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Materiales>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<MaximosXDepositos>(entity =>
            {
                entity.HasKey(e => new { e.Codart, e.Deposi });
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<ModeloAceite>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<MontosXCuenta>(entity =>
            {
                entity.Property(e => e.Ctacte).ValueGeneratedNever();
            });

            modelBuilder.Entity<Motivos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<MovArticulos>(entity =>
            {
                entity.Property(e => e.Nroint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movbancos>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Asient, e.Reglon });

                entity.HasOne(d => d.NumeroNavigation)
                    .WithMany(p => p.Movbancos)
                    .HasForeignKey(d => d.Numero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVBANCOS_NUMERO");
            });

            modelBuilder.Entity<Movcajas>(entity =>
            {
                entity.Property(e => e.Nromov).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movcheques3>(entity =>
            {
                entity.HasKey(e => new { e.Numint, e.Asient });

                entity.Property(e => e.Caja).HasDefaultValueSql("DEFAULT 1");

                entity.HasOne(d => d.NumintNavigation)
                    .WithMany(p => p.Movcheques3)
                    .HasForeignKey(d => d.Numint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVCHEQUES3_NUMINT");
            });

            modelBuilder.Entity<Movchequespro>(entity =>
            {
                entity.HasKey(e => new { e.Cheque, e.Numero, e.Asient });

                entity.Property(e => e.Caja).HasDefaultValueSql("DEFAULT 1");

                entity.HasOne(d => d.Chequespro)
                    .WithMany(p => p.Movchequespro)
                    .HasForeignKey(d => new { d.Cheque, d.Numero })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVCHEQUESPRO_CHENUM");
            });

            modelBuilder.Entity<Movcontables>(entity =>
            {
                entity.Property(e => e.Asient).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movcupones>(entity =>
            {
                entity.HasKey(e => new { e.Numint, e.Asient });

                entity.Property(e => e.Caja).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Fecha).HasDefaultValueSql("DEFAULT 'NOW'");

                entity.HasOne(d => d.NumintNavigation)
                    .WithMany(p => p.Movcupones)
                    .HasForeignKey(d => d.Numint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVCUPON_REFERENCE_CUPONES");
            });

            modelBuilder.Entity<Movestadosdes>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<MovManodeobra>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.MovManodeobra)
                    .HasForeignKey(d => d.Asient)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MOV_MANO_REF_MOVCONTABLES");
            });

            modelBuilder.Entity<MovMateriales>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movnocontables>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Estado).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Movobras>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movproyectoscontables>(entity =>
            {
                entity.HasKey(e => new { e.Proyec, e.Asient });

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Movproyectoscontables)
                    .HasForeignKey(d => d.Asient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVPROYECTOSCON_ASIENT");
            });

            modelBuilder.Entity<Movproyectosnocontables>(entity =>
            {
                entity.HasKey(e => new { e.Proyec, e.Nocont });
            });

            modelBuilder.Entity<MovRelaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Nummot).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Usuari).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Movrma>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movrmapro>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movserialesart>(entity =>
            {
                entity.HasKey(e => new { e.Movart, e.Nroser });
            });

            modelBuilder.Entity<Movserialescontables>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Reglon, e.Nroser });

                entity.HasOne(d => d.Detmovcontables)
                    .WithMany(p => p.Movserialescontables)
                    .HasForeignKey(d => new { d.Asient, d.Reglon })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MOVSERIALESCONTABLES_ASIREG");
            });

            modelBuilder.Entity<Movserialesnocon>(entity =>
            {
                entity.HasKey(e => new { e.Nocont, e.Nroser });
            });

            modelBuilder.Entity<Movtransporte>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Movventas>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Vended });

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Movventas)
                    .HasForeignKey(d => d.Asient)
                    .HasConstraintName("FK_MOVVENTAS_ASIENT");
            });

            modelBuilder.Entity<Negociaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Enviad).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<NegoContables>(entity =>
            {
                entity.HasKey(e => new { e.Negoci, e.Asient, e.Reglon });

                entity.HasOne(d => d.Detmovcontables)
                    .WithMany(p => p.NegoContables)
                    .HasForeignKey(d => new { d.Asient, d.Reglon })
                    .HasConstraintName("FK_NEGO_CONTABLES_ASIREG");
            });

            modelBuilder.Entity<NegoNocon>(entity =>
            {
                entity.HasKey(e => new { e.Negoci, e.Nocont });
            });

            modelBuilder.Entity<Noconxcon>(entity =>
            {
                entity.HasKey(e => new { e.Numnco, e.Numcon });
            });

            modelBuilder.Entity<Nrosdespachos>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Deposi).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Obras>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Deposi).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Oferta>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<OrdenReparacion>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Cantur).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<Orientaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Origenes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<OtLub>(entity =>
            {
                entity.HasKey(e => new { e.Nocont, e.Vehicu });
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Parametros>(entity =>
            {
                entity.HasKey(e => new { e.Empres, e.Codigo });

                entity.Property(e => e.Boole1).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Boole2).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pergrupo>(entity =>
            {
                entity.HasKey(e => new { e.Casous, e.Grupo });
            });

            modelBuilder.Entity<Perusuarios>(entity =>
            {
                entity.HasKey(e => new { e.Casous, e.Usuari });

                entity.Property(e => e.Habili).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Pesajes>(entity =>
            {
                entity.Property(e => e.Numint)
                    .ValueGeneratedNever()
                    .HasAnnotation("Description", "GEN:GEN_PESAJES");

                entity.Property(e => e.Anulad).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Lugcar).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Picking>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<PickingConta>(entity =>
            {
                entity.HasKey(e => new { e.Asient, e.Nropic });

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.PickingConta)
                    .HasForeignKey(d => d.Asient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PICKING_CONTA_2");
            });

            modelBuilder.Entity<PickingEstados>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<PickingNocon>(entity =>
            {
                entity.HasKey(e => new { e.Nocont, e.Nropic });
            });

            modelBuilder.Entity<PickingUser>(entity =>
            {
                entity.HasKey(e => new { e.Usuari, e.Nropic });
            });

            modelBuilder.Entity<Plancomision>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Plancuentas>(entity =>
            {
                entity.Property(e => e.Cuenta).ValueGeneratedNever();

                entity.Property(e => e.Cuecaj).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Cuedes).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Gencta).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Habili).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Moneda).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Percep).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Presup).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Prorra).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Resumi).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Plancuotas>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.HasOne(d => d.AsientNavigation)
                    .WithMany(p => p.Plancuotas)
                    .HasForeignKey(d => d.Asient)
                    .HasConstraintName("FK_PLANCUOTAS_ASIENT");
            });

            modelBuilder.Entity<PlanesPro>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Plantilla>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Plantran>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<PreciosXListapre>(entity =>
            {
                entity.HasKey(e => new { e.Fecvig, e.Codart, e.Lista });

                entity.Property(e => e.Fecvig).HasDefaultValueSql("DEFAULT '2000/01/01'");
            });

            modelBuilder.Entity<Presentaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<PresupCtas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.PresupCtas)
                    .HasForeignKey(d => d.Cuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRESUP_CTAS_CUENTA");
            });

            modelBuilder.Entity<Presupuestos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProcesosArt>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Profesionales>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Proyectosobras>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reggan>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Regibr>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Regiva>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reglascompro>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reportes>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<ResponsablesRelaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rma>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rubros>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<RubrosArt>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sectores>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Seguimientoor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Seriales>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<StockDeMateriales>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Subproductos>(entity =>
            {
                entity.HasKey(e => new { e.Produc, e.Subpro });
            });

            modelBuilder.Entity<SubrubrosArt>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sucursales>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TablasCompro>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Talonarios>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Concae).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Eliimp).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Imprim).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Local).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Nopcop).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Pregun).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Unineg).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.Vispre).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Tareas>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tarjetas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblComproIva>(entity =>
            {
                entity.HasKey(e => new { e.Codcom, e.Letra });
            });

            modelBuilder.Entity<Tecnicosor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Temas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tercerizacionesor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipmon>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipoasientos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoCash>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipochequeras>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Orient).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Tiphoj).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<Tipocom>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipocuebanco>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipocuenta>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Cuenta).HasDefaultValueSql("DEFAULT 100000000000");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Tipocuenta)
                    .HasForeignKey(d => d.Cuenta)
                    .HasConstraintName("FK_TIPOCUENTA_CUENTA");
            });

            modelBuilder.Entity<TipoHoja>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipoimagenes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipoimpresion>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipomaquinas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipomensajes>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipomonedas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipomov>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tipoplancuenta>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoRelaciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tiposaranceles>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tiposcodbarra>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tiposcodret>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TiposContratos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tiposlayout>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TiposProyectos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TipoTarjeta>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Transacciones>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransCisterna>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransCombustible>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransDistancias>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransEstados>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransIncoterms>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransOrdenes>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();

                entity.Property(e => e.Numemp).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<TransOriDes>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Transportes>(entity =>
            {
                entity.Property(e => e.Cuenta).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransRemolque>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Numide).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<TransSurtidor>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Deposi).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<TransTipoDoc>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransVencXChofer>(entity =>
            {
                entity.HasKey(e => new { e.Numcho, e.Numdoc });
            });

            modelBuilder.Entity<TransVencXRemolque>(entity =>
            {
                entity.HasKey(e => new { e.Numrem, e.Numdoc });
            });

            modelBuilder.Entity<TransVencXVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.Numveh, e.Numdoc });
            });

            modelBuilder.Entity<TurnosLub>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Hora, e.Fosa });
            });

            modelBuilder.Entity<UbicacionesArt>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Unidades>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Unidadnegocio>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });

            modelBuilder.Entity<Usecase>(entity =>
            {
                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Bloque).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Esnodo).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Oculta).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Esroot).HasAnnotation("Description", "TIP:BOOLEAN");

                entity.Property(e => e.Habili).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Usuxgru>(entity =>
            {
                entity.HasKey(e => new { e.Usuari, e.Grupo });
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Client).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Modace).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Modelo).HasDefaultValueSql("DEFAULT 1");

                entity.Property(e => e.Movil).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<Vehxtra>(entity =>
            {
                entity.HasKey(e => new { e.Numtra, e.Numveh });
            });

            modelBuilder.Entity<VencimientosXVta>(entity =>
            {
                entity.Property(e => e.Numint).ValueGeneratedNever();
            });

            modelBuilder.Entity<Vendedores>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();

                entity.Property(e => e.Deshab).HasAnnotation("Description", "TIP:BOOLEAN");
            });

            modelBuilder.Entity<Zonas>(entity =>
            {
                entity.Property(e => e.Numero).ValueGeneratedNever();
            });
        }
    }
}
