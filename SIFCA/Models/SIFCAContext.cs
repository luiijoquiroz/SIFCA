using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SIFCA.Models
{
    public class SIFCAContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SIFCAContext() : base("name=SIFCAContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //Quitar Borrado en Cascadas
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<SIFCA.Models.TipodePrestamos> TipodePrestamos { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Patrono> Patronoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Banco> Bancoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Cargos> Cargos { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.CatalogodeCuenta> CatalogodeCuentas { get; set; }
        
        public System.Data.Entity.DbSet<SIFCA.Models.Nomina> ConceptodeNominas { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.CondiciondePago> CondiciondePagoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.FamiliarSocio> DatosFamiliaresSocios { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.LaboralesSocio> DatosLaboralesSocios { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.PersonalesSocio> PersonalesSocios { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Departamento> Departamentoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Dependencia> Dependencias { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Direcciones> Direcciones { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.EjercicioFiscal> EjercicioFiscals { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Estados> Estados { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Estatus> Estatus { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.GrupoDirectivos> GrupoDirectivos { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Titulos> Titulos { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.TipodeSocio> TipodeSocios { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.SociosxGrupoDirectivo> SociosxGrupoDirectivoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.SectorEconomico> SectoresEconomicos { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.RolesporGrupoDirectivo> RolesporGrupoDirectivoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Rol> Roles { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.RedesSocial> RedesSocials { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.PeriodoMensual> PeriodoMensuals { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.MetododePago> MetododePagoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.MetododePagoporBanco> MetododePagoporBancoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Contacto> Contactoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.UnidaddeTiempo> UnidaddeTiempoes { get; set; }

        public System.Data.Entity.DbSet<SIFCA.Models.Instituciones> Instituciones { get; set; }

    }
}
