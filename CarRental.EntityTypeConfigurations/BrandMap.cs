using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
   public class BrandMap: EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            Property(b => b.BrandName)
                .HasMaxLength(25);
            HasMany(p => p.Model)
                .WithRequired(w => w.Brand)
                .HasForeignKey(w => w.BrandId)
                .WillCascadeOnDelete(false);
        }
    }
}
