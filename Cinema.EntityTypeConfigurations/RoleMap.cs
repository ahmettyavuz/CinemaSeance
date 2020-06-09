using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EntityTypeConfigurations
{
    public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            HasKey(r => r.Id);

            Property(r => r.RoleName)
             .HasMaxLength(30)
             .IsUnicode(false)
             .IsRequired();

            Property(r => r.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("date")
                .IsRequired();

            Property(r => r.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(r => r.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(r => r.UserId)
                .HasColumnName("UserId");

            Property(r => r.IsActive)
                .HasColumnName("IsActive");
            //UserRole
            HasMany(r => r.Users)
                .WithMany(u => u.Roles)
                .Map(m =>
                {
                    m.ToTable("UserRole");
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("UserId");
                });
        }
    }
}
