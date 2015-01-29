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
            if (context.MySelf.Count()==0){
            context.MySelf.AddOrUpdate(new MySelf { Name = "Ivo", Born =DateTime.Parse("03/05/1985"), ImageUrl = @"ProfilePicture.jpg", Info = "Проект за ИнфоСтарт Адрес в GITHUB:https://github.com/IvoAtanasov/DairyInfoStart" });
            context.SaveChanges();
        }
        }
    }
}
