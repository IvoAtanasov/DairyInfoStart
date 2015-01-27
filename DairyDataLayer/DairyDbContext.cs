namespace DairyDataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using DairyModelLayer;
    public  class DairyDbContext : DbContext
    {
        public DairyDbContext()
            : base("DairyDbContext")
        {
          //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<DairyDbContex, Configuration>());
        }
        public DbSet<Story> Story { get; set; }
        public DbSet<MySelf> MySelf { get; set; }
    }
}
