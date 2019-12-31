namespace CarRental.DAL.Migrations
{
    using CarRentalEntities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarRental.DAL.CarRentalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarRental.DAL.CarRentalDbContext context)
        {
            //Role role = new Role();
            //role.Id = Guid.NewGuid();
            //role.RoleName = "admin";
            //User user = new User();
            //user.Id = Guid.NewGuid();
            //user.UserName = "deneme";
            //user.Password = "1";
            //user.Role.Add(role);
            //context.Users.Add(user);
            //context.SaveChanges();
            //base.Seed(context);
        }
    }
}
