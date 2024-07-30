namespace EdiFabric.Templates.EdifactD96A
{
    using EdiFabric.Core.Model.Edi.Edifact;
    using Microsoft.EntityFrameworkCore;


    public class EDIFACTContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EDIFACT_D96A_ORDERS;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<AJT> AJT { get; set; }
        public DbSet<ALC> ALC { get; set; }
        public DbSet<ALI> ALI { get; set; }
        public DbSet<APR> APR { get; set; }
        public DbSet<BGM> BGM { get; set; }
        public DbSet<CAV> CAV { get; set; }
        public DbSet<CCI> CCI { get; set; }
        public DbSet<CNI> CNI { get; set; }
        public DbSet<CNT> CNT { get; set; }
        public DbSet<COM> COM { get; set; }
        public DbSet<CPI> CPI { get; set; }
        public DbSet<CPS> CPS { get; set; }
        public DbSet<CTA> CTA { get; set; }
        public DbSet<CUX> CUX { get; set; }
        public DbSet<DGS> DGS { get; set; }
        public DbSet<DIM> DIM { get; set; }
        public DbSet<DLM> DLM { get; set; }
        public DbSet<DOC> DOC { get; set; }
        public DbSet<DTM> DTM { get; set; }
        public DbSet<EQA> EQA { get; set; }
        public DbSet<EQD> EQD { get; set; }
        public DbSet<EQN> EQN { get; set; }
        public DbSet<FII> FII { get; set; }
        public DbSet<FTX> FTX { get; set; }
        public DbSet<GDS> GDS { get; set; }
        public DbSet<GID> GID { get; set; }
        public DbSet<GIN> GIN { get; set; }
        public DbSet<GIR> GIR { get; set; }
        public DbSet<GOR> GOR { get; set; }
        public DbSet<HAN> HAN { get; set; }
        public DbSet<IMD> IMD { get; set; }
        public DbSet<INP> INP { get; set; }
        public DbSet<LIN> LIN { get; set; }
        public DbSet<LOC> LOC { get; set; }
        public DbSet<MEA> MEA { get; set; }
        public DbSet<MOA> MOA { get; set; }
        public DbSet<NAD> NAD { get; set; }
        public DbSet<PAC> PAC { get; set; }
        public DbSet<PAI> PAI { get; set; }
        public DbSet<PAT> PAT { get; set; }
        public DbSet<PCD> PCD { get; set; }
        public DbSet<PCI> PCI { get; set; }
        public DbSet<PGI> PGI { get; set; }
        public DbSet<PIA> PIA { get; set; }
        public DbSet<PRI> PRI { get; set; }
        public DbSet<QTY> QTY { get; set; }
        public DbSet<QVR> QVR { get; set; }
        public DbSet<RCS> RCS { get; set; }
        public DbSet<RFF> RFF { get; set; }
        public DbSet<RNG> RNG { get; set; }
        public DbSet<RTE> RTE { get; set; }
        public DbSet<SCC> SCC { get; set; }
        public DbSet<SEL> SEL { get; set; }
        public DbSet<SGP> SGP { get; set; }
        public DbSet<STG> STG { get; set; }
        public DbSet<STS> STS { get; set; }
        public DbSet<TAX> TAX { get; set; }
        public DbSet<TCC> TCC { get; set; }
        public DbSet<TDT> TDT { get; set; }
        public DbSet<TMD> TMD { get; set; }
        public DbSet<TMP> TMP { get; set; }
        public DbSet<TOD> TOD { get; set; }
        public DbSet<TPL> TPL { get; set; }
        public DbSet<TSR> TSR { get; set; }
        public DbSet<UNS> UNS { get; set; }
        public DbSet<UNH> UNH { get; set; }
        public DbSet<S009> S009 { get; set; }
        public DbSet<S010> S010 { get; set; }
        public DbSet<S016> S016 { get; set; }
        public DbSet<S017> S017 { get; set; }
        public DbSet<S018> S018 { get; set; }
        public DbSet<UNT> UNT { get; set; }
        public DbSet<C002> C002 { get; set; }
        public DbSet<C040> C040 { get; set; }
        public DbSet<C056> C056 { get; set; }
        public DbSet<C058> C058 { get; set; }
        public DbSet<C059> C059 { get; set; }
        public DbSet<C076> C076 { get; set; }
        public DbSet<C078> C078 { get; set; }
        public DbSet<C080> C080 { get; set; }
        public DbSet<C082> C082 { get; set; }
        public DbSet<C088> C088 { get; set; }
        public DbSet<C100> C100 { get; set; }
        public DbSet<C107> C107 { get; set; }
        public DbSet<C108> C108 { get; set; }
        public DbSet<C110> C110 { get; set; }
        public DbSet<C112> C112 { get; set; }
        public DbSet<C128> C128 { get; set; }
        public DbSet<C138> C138 { get; set; }
        public DbSet<C174> C174 { get; set; }
        public DbSet<C186> C186 { get; set; }
        public DbSet<C200> C200 { get; set; }
        public DbSet<C202> C202 { get; set; }
        public DbSet<C203> C203 { get; set; }
        public DbSet<C205> C205 { get; set; }
        public DbSet<C206> C206 { get; set; }
        public DbSet<C208> C208 { get; set; }
        public DbSet<C210> C210 { get; set; }
        public DbSet<C211> C211 { get; set; }
        public DbSet<C212> C212 { get; set; }
        public DbSet<C213> C213 { get; set; }
        public DbSet<C214> C214 { get; set; }
        public DbSet<C215> C215 { get; set; }
        public DbSet<C218> C218 { get; set; }
        public DbSet<C219> C219 { get; set; }
        public DbSet<C220> C220 { get; set; }
        public DbSet<C222> C222 { get; set; }
        public DbSet<C223> C223 { get; set; }
        public DbSet<C224> C224 { get; set; }
        public DbSet<C228> C228 { get; set; }
        public DbSet<C229> C229 { get; set; }
        public DbSet<C231> C231 { get; set; }
        public DbSet<C232> C232 { get; set; }
        public DbSet<C233> C233 { get; set; }
        public DbSet<C234> C234 { get; set; }
        public DbSet<C235> C235 { get; set; }
        public DbSet<C236> C236 { get; set; }
        public DbSet<C237> C237 { get; set; }
        public DbSet<C239> C239 { get; set; }
        public DbSet<C240> C240 { get; set; }
        public DbSet<C241> C241 { get; set; }
        public DbSet<C243> C243 { get; set; }
        public DbSet<C270> C270 { get; set; }
        public DbSet<C273> C273 { get; set; }
        public DbSet<C279> C279 { get; set; }
        public DbSet<C280> C280 { get; set; }
        public DbSet<C288> C288 { get; set; }
        public DbSet<C329> C329 { get; set; }
        public DbSet<C401> C401 { get; set; }
        public DbSet<C402> C402 { get; set; }
        public DbSet<C501> C501 { get; set; }
        public DbSet<C502> C502 { get; set; }
        public DbSet<C503> C503 { get; set; }
        public DbSet<C504> C504 { get; set; }
        public DbSet<C506> C506 { get; set; }
        public DbSet<C507> C507 { get; set; }
        public DbSet<C509> C509 { get; set; }
        public DbSet<C516> C516 { get; set; }
        public DbSet<C517> C517 { get; set; }
        public DbSet<C519> C519 { get; set; }
        public DbSet<C522> C522 { get; set; }
        public DbSet<C523> C523 { get; set; }
        public DbSet<C524> C524 { get; set; }
        public DbSet<C528> C528 { get; set; }
        public DbSet<C531> C531 { get; set; }
        public DbSet<C532> C532 { get; set; }
        public DbSet<C533> C533 { get; set; }
        public DbSet<C534> C534 { get; set; }
        public DbSet<C536> C536 { get; set; }
        public DbSet<C537> C537 { get; set; }
        public DbSet<C550> C550 { get; set; }
        public DbSet<C552> C552 { get; set; }
        public DbSet<C553> C553 { get; set; }
        public DbSet<C554> C554 { get; set; }
        public DbSet<C555> C555 { get; set; }
        public DbSet<C556> C556 { get; set; }
        public DbSet<C601> C601 { get; set; }
        public DbSet<C703> C703 { get; set; }
        public DbSet<C827> C827 { get; set; }
        public DbSet<C829> C829 { get; set; }
        public DbSet<C849> C849 { get; set; }
        public DbSet<C850> C850 { get; set; }
        public DbSet<C889> C889 { get; set; }
        public DbSet<C960> C960 { get; set; }
             
        public DbSet<Loop_ALC_ORDERS> Loop_ALC_ORDERS { get; set; }
        public DbSet<Loop_ALC_ORDERS_2> Loop_ALC_ORDERS_2 { get; set; }
        public DbSet<Loop_APR_ORDERS> Loop_APR_ORDERS { get; set; }
        public DbSet<Loop_CCI_ORDERS> Loop_CCI_ORDERS { get; set; }
        public DbSet<Loop_CTA_ORDERS> Loop_CTA_ORDERS { get; set; }
        public DbSet<Loop_CUX_ORDERS> Loop_CUX_ORDERS { get; set; }
        public DbSet<Loop_DOC_ORDERS> Loop_DOC_ORDERS { get; set; }
        public DbSet<Loop_EQD_ORDERS> Loop_EQD_ORDERS { get; set; }
        public DbSet<Loop_LIN_ORDERS> Loop_LIN_ORDERS { get; set; }
        public DbSet<Loop_LOC_ORDERS> Loop_LOC_ORDERS { get; set; }
        public DbSet<Loop_LOC_ORDERS_2> Loop_LOC_ORDERS_2 { get; set; }
        public DbSet<Loop_MOA_ORDERS> Loop_MOA_ORDERS { get; set; }
        public DbSet<Loop_NAD_ORDERS> Loop_NAD_ORDERS { get; set; }
        public DbSet<Loop_NAD_ORDERS_2> Loop_NAD_ORDERS_2 { get; set; }
        public DbSet<Loop_PAC_ORDERS> Loop_PAC_ORDERS { get; set; }
        public DbSet<Loop_PAC_ORDERS_2> Loop_PAC_ORDERS_2 { get; set; }
        public DbSet<Loop_PAT_ORDERS> Loop_PAT_ORDERS { get; set; }
        public DbSet<Loop_PCD_ORDERS> Loop_PCD_ORDERS { get; set; }
        public DbSet<Loop_PCI_ORDERS> Loop_PCI_ORDERS { get; set; }
        public DbSet<Loop_PRI_ORDERS> Loop_PRI_ORDERS { get; set; }
        public DbSet<Loop_QTY_ORDERS> Loop_QTY_ORDERS { get; set; }
        public DbSet<Loop_QTY_ORDERS_2> Loop_QTY_ORDERS_2 { get; set; }
        public DbSet<Loop_QTY_ORDERS_3> Loop_QTY_ORDERS_3 { get; set; }
        public DbSet<Loop_RCS_ORDERS> Loop_RCS_ORDERS { get; set; }
        public DbSet<Loop_RFF_ORDERS> Loop_RFF_ORDERS { get; set; }
        public DbSet<Loop_RTE_ORDERS> Loop_RTE_ORDERS { get; set; }
        public DbSet<Loop_SCC_ORDERS> Loop_SCC_ORDERS { get; set; }
        public DbSet<Loop_STG_ORDERS> Loop_STG_ORDERS { get; set; }
        public DbSet<Loop_TAX_ORDERS> Loop_TAX_ORDERS { get; set; }
        public DbSet<Loop_TAX_ORDERS_2> Loop_TAX_ORDERS_2 { get; set; }
        public DbSet<Loop_TDT_ORDERS> Loop_TDT_ORDERS { get; set; }
        public DbSet<Loop_TOD_ORDERS> Loop_TOD_ORDERS { get; set; }
        public DbSet<TSORDERS> TSORDERS { get; set; }       
    }
}