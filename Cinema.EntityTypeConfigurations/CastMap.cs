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
    public class CastMap:EntityTypeConfiguration<Cast>
    {
        public CastMap()
        {
            HasKey(c => c.Id);

            Property(c => c.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(c => c.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(c => c.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(c => c.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("date")
                .IsRequired();

            Property(c => c.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(c => c.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(c => c.UserId)
                .HasColumnName("UserId");

            Property(c => c.IsActive)
                .HasColumnName("IsActive");
            //CastMovie
            HasMany(c => c.Movies)
                .WithMany(m => m.Casts)
                .Map(m =>
                {
                    m.ToTable("CastMovie");
                    m.MapLeftKey("CastId");
                    m.MapRightKey("MovieId");
                });
        }
    }
}
