using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Aciklama;
using VemaTextile.DAL.ORM.EntityFramework.Mappings.Alinan;
using VemaTextile.Models.Class;

namespace VemaTextile.DAL.ORM.EntityFramework.Context
{
    class ProjectContext : DbContext
    {

        public ProjectContext() : base("name=dbConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectContext>());
        }

        public DbSet<AciklamaTanimlar> AciklamaTanimlars { get; set; }
        public DbSet<AlinanCekler> AlinanCeklers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AciklamaMap());
            modelBuilder.Configurations.Add(new AlinanCeklerMap());
            modelBuilder.Conventions.Add(new PluralizingTableNameConvention());
        }
    }
}
