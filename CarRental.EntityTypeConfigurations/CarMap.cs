using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class CarMap: EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            Property(c => c.DailyPrice)
                 .HasMaxLength(9)
                 .IsRequired()
                 .IsUnicode(false);
            Property(c => c.InsuranceExpiryDate)
                .IsRequired()
                .HasColumnType("date");
            Property(c => c.InspectionExpiryDate)
                .IsRequired()
                .HasColumnType("date");
            Property(c => c.DateOfPurchase)
               .IsRequired()
               .HasColumnType("date");
            Property(c => c.Plate)
               .IsRequired()
               .HasMaxLength(11);

            HasMany(p => p.RentedCar)
                .WithRequired(w => w.Car)
                .HasForeignKey(w => w.CarId)
                .WillCascadeOnDelete(false);
            HasRequired(m => m.Model)
                .WithMany(c => c.Cars)
                .HasForeignKey(c => c.ModelId)
                .WillCascadeOnDelete(false);

        }
    }
}
