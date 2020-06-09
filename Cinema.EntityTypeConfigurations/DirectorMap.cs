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
    public class DirectorMap:EntityTypeConfiguration<Director>
    {
        public DirectorMap()
        {
            HasKey(d => d.Id);

            Property(d => d.FirstName)
             .HasMaxLength(30)
             .IsUnicode(false)
             .IsRequired();

            Property(d => d.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(d => d.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("date")
                .IsRequired();

            Property(d => d.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(d => d.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(d => d.UserId)
                .HasColumnName("UserId");

            Property(d => d.IsActive)
                .HasColumnName("IsActive");
            //DirectorMovie
            HasMany(d => d.Movies)
               .WithMany(m => m.Directors)
               .Map(m =>
               {
                   m.ToTable("DirectorMovie");
                   m.MapLeftKey("DirectorId");
                   m.MapRightKey("MovieId");
               });
        }
    }
}
