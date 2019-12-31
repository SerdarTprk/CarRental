using CarRental.EntityTypeConfigurations;
using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL
{
    public class CarRentalDbContext : DbContext
    {
        public CarRentalDbContext() : base("server=213.14.169.11;database=CarRentalDb;User=bak402;Password=Alaf9090")
        {
            
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
            Database.SetInitializer<CarRentalDbContext>(new DropCreateDatabaseIfModelChanges<CarRentalDbContext>());
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<RentedCar> RentedCars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new RentedCarMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new ModelMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new RoleMap());


        }

    }
}

