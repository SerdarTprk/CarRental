using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class ModelMap: EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            Property(m => m.ModelName)
                .HasMaxLength(25)
                .IsRequired();
            Property(m => m.ModelYear)
                .HasColumnType("date");

            HasRequired(p => p.Brand)
                .WithMany(wd => wd.Model)
                .HasForeignKey(wd => wd.BrandId)
                .WillCascadeOnDelete(false);
            HasMany(c => c.Cars)
                .WithRequired(m => m.Model)
                .HasForeignKey(c => c.ModelId)
                .WillCascadeOnDelete(false);
        }
    }
}
