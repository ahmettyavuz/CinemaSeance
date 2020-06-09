using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EntityTypeConfigurations
{
    public class SeatSaleMap:EntityTypeConfiguration<SeatSale>
    {
        public SeatSaleMap()
        {
            HasKey(s => s.Id);

            Property(s => s.Price)
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

            Property(s => s.SeatId)
                .HasColumnAnnotation
                (IndexAnnotation.AnnotationName,
                  new IndexAnnotation(
                  new IndexAttribute("CompositeKey", 1) { IsUnique = true }));

            Property(s => s.SessionId)
                .HasColumnAnnotation
                (IndexAnnotation.AnnotationName,
                  new IndexAnnotation(
                  new IndexAttribute("CompositeKey", 2) { IsUnique = true }));

            //Ticket
            HasRequired(ss => ss.Tickets)
               .WithMany(s => s.SeatSales)
               .HasForeignKey(ss => ss.TicketId)
               .WillCascadeOnDelete(false);
            //Seat
            HasRequired(ss => ss.Seat)
                .WithMany(s => s.SeatSales)
                .HasForeignKey(ss => ss.SeatId)
                .WillCascadeOnDelete(false);
            //Session
            HasRequired(ss => ss.Session)
                .WithMany(s => s.SeatSales)
                .HasForeignKey(ss => ss.SessionId)
                .WillCascadeOnDelete(false);
        }
    }
}
