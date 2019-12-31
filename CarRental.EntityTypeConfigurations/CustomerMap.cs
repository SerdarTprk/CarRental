using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            Property(c => c.FirstName)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
            Property(c => c.LastName)
               .HasMaxLength(50)
               .IsRequired()
               .IsUnicode(false);
            Property(c => c.E_mail)
               .HasMaxLength(50)
               .IsRequired()
               .IsUnicode(false);
            Property(c => c.Adress)
               .HasMaxLength(200)
               .IsRequired()
               .IsUnicode(false);
            Property(c => c.TcNo)
                .HasMaxLength(11).IsFixedLength()
               .IsRequired()
               .IsUnicode(false);

            HasMany(p => p.RentedCar)
                .WithRequired(w => w.Customer)
                .HasForeignKey(w => w.CustomerId)
                .WillCascadeOnDelete(false);


        }
    }
}
