using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class RentedCarMap: EntityTypeConfiguration<RentedCar>
    {
        public RentedCarMap()
        {
            Property(r => r.Description)
                .HasMaxLength(120)
                .IsOptional()
                .IsUnicode(false);
            Property(r => r.DeliveredDate)
                .IsRequired()
                .HasColumnType("date");


            HasRequired(p => p.Customer)
                .WithMany(wd => wd.RentedCar)
                .HasForeignKey(wd => wd.CustomerId);

        }
    }
}
