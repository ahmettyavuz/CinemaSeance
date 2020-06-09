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
    public class MovieMap:EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            HasKey(m => m.Id);

            Property(m => m.MovieName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired();

            Property(m => m.MovieTime)
                .IsRequired();

            Property(m => m.TD)
                .HasColumnName("3D")
                .IsRequired();

            Property(m => m.Year)
                .IsRequired();

            Property(m => m.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("date")
                .IsRequired();

            Property(m => m.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(m => m.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(m => m.UserId)
                .HasColumnName("UserId");

            Property(m => m.IsActive)
                .HasColumnName("IsActive");
            //Session
            HasMany(m => m.Sessions)
               .WithRequired(s => s.Movie)
               .HasForeignKey(s => s.MovieId)
               .WillCascadeOnDelete(false);
        }
    }
}
