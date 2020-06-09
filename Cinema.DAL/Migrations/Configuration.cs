namespace Cinema.DAL.Migrations
{
    using Cinema.Entity.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cinema.DAL.CinemaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cinema.DAL.CinemaDbContext context)
        {

                //User user = new User();
                //user.Id = Guid.NewGuid();
                //user.UserName = "admin";
                //user.Password = "admin";
                //user.CreatedDate = DateTime.Now;
                //user.IsActive = true;

                //Role roleAdmin = new Role()
                //{
                //    Id = Guid.NewGuid(),
                //    RoleName = "Admin",
                //    IsActive = true,
                //    CreatedDate = DateTime.Now
                //};
                //user.Roles.Add(roleAdmin);
                //context.Users.Add(user);


                //context.Roles.AddOrUpdate(
                //new Role()
                //{
                //    Id = Guid.NewGuid(),
                //    RoleName = "İşletmeci",
                //    IsActive = true,
                //    CreatedDate = DateTime.Now
                //},
                //new Role()
                //{
                //    Id = Guid.NewGuid(),
                //    RoleName = "Gişeci",
                //    IsActive = true,
                //    CreatedDate = DateTime.Now
                //});
                //context.SaveChanges();
                //base.Seed(context);
            
        }
    }
}
