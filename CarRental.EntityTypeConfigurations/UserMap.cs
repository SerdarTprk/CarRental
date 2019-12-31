using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.EntityTypeConfigurations
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            Property(u => u.UserName)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
            Property(u => u.Password)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode(false);



            HasMany<Role>(s => s.Role)
                 .WithMany(c => c.User)
                 .Map(cs =>
                 {
                     cs.MapRightKey("RoleId");
                     cs.MapLeftKey("UserId");
                     cs.ToTable("RoleUser");
                 });
        }
    }
}
