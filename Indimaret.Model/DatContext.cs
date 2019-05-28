using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class DatContext : DbContext
    {
        public DatContext() : base("Name=IndimaretConn")
        {
            //Database.SetInitializer(new Initializer());
            Database.SetInitializer<DatContext>(null);
        }

        public virtual DbSet<MBarang> Master_Barangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
