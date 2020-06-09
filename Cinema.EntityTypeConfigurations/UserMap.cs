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
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(u => u.Id);

            Property(u => u.UserName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(u => u.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(u => u.CreatedDate)
               .HasColumnName("CreatedDate")
               .HasColumnType("date")
               .IsRequired();

            Property(u => u.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(u => u.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(u => u.UserId)
                .HasColumnName("UserId");

            Property(u => u.IsActive)
                .HasColumnName("IsActive");
            //UserRole
            HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m =>
                {
                    m.ToTable("UserRole");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");
                });
        }
    }
}
