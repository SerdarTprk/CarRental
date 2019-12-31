using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class RoleMap: EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            HasMany<User>(s => s.User)
                 .WithMany(c => c.Role)
                
                 .Map(cs =>
                 {
                     cs.MapLeftKey("RoleId");
                     cs.MapRightKey("UserId");
                     cs.ToTable("RoleUser");
                     
                 });
            
        }
    }
}
