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
    public class TheaterMap:EntityTypeConfiguration<Theater>
    {
        public TheaterMap()
        {
            HasKey(t => t.Id);

            Property(t => t.TheaterName)
                .IsUnicode()
                .HasMaxLength(30)
                .IsRequired();

            Property(t => t.CreatedDate)
               .HasColumnName("CreatedDate")
               .HasColumnType("date")
               .IsRequired();

            Property(t => t.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(t => t.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(t => t.UserId)
                .HasColumnName("UserId");

            Property(t => t.IsActive)
                .HasColumnName("IsActive");
            //Sessions
            HasMany(s => s.Sessions)
                .WithRequired(s => s.Theater)
                .HasForeignKey(s => s.TheaterId)
                .WillCascadeOnDelete(false);
            //Seat
            HasMany(t => t.Seats)
                .WithRequired(s => s.Theater)
                .HasForeignKey(t => t.TheaterId)
                .WillCascadeOnDelete(false);
        }
    }
}
