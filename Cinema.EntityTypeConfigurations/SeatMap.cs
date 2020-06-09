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
    public class SeatMap:EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            HasKey(s => s.Id);

            Property(s => s.SeatNo)
                 .IsRequired();

            Property(s => s.CreatedDate)
               .HasColumnName("CreatedDate")
               .HasColumnType("date")
               .IsRequired();

            Property(s => s.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(s => s.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(s => s.UserId)
                .HasColumnName("UserId");

            Property(s => s.IsActive)
                .HasColumnName("IsActive");
            //Theater
            HasRequired(s => s.Theater)
                .WithMany(t => t.Seats)
                .HasForeignKey(t => t.TheaterId)
                .WillCascadeOnDelete(false);
            //SeatSale
            HasMany(s => s.SeatSales)
                .WithRequired(ss => ss.Seat)
                .HasForeignKey(ss => ss.SeatId)
                .WillCascadeOnDelete(false);
        }
    }
}
