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
    public class TicketMap:EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            HasKey(t => t.Id);


            Property(t => t.Cost)
                .IsRequired();

            Property(t => t.Date)
                .HasColumnType("datetime")
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
            //SeatSales
            HasMany(s => s.SeatSales)
                 .WithRequired(t => t.Tickets)
                 .HasForeignKey(s => s.TicketId)
                 .WillCascadeOnDelete(false);

        }
    }
}
