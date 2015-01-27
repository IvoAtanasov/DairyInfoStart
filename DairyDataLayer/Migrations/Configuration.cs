namespace DairyDataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DairyModelLayer;

    internal sealed class Configuration : DbMigrationsConfiguration<DairyDataLayer.DairyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
      
        }

        protected override void Seed(DairyDataLayer.DairyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //context.MySelf.AddOrUpdate(new MySelf{Name="Ivo",Born=DateTime.Now, ImageUrl=@"~\Content\Images\ProfilePicture.jpg"} );
            //context.SaveChanges();
        }
    }
}
