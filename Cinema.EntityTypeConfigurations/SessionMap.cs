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
    public class SessionMap:EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            HasKey(s => s.Id);

            Property(s => s.ShowDate)
                .HasColumnType("date")
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
            //SeatSales
            HasMany(s => s.SeatSales)
                .WithRequired(ss => ss.Session)
                .HasForeignKey(ss => ss.SessionId)
                .WillCascadeOnDelete(false);
            //Seance
            HasRequired(ss => ss.Seance)
                .WithMany(s => s.Sessions)
                .HasForeignKey(ss => ss.SeanceId)
                .WillCascadeOnDelete(false);
            //Theater
            HasRequired(s => s.Theater)
                .WithMany(t => t.Sessions)
                .HasForeignKey(s => s.TheaterId)
                .WillCascadeOnDelete(false);
            //Movie
            HasRequired(s => s.Movie)
                .WithMany(m => m.Sessions)
                .HasForeignKey(s => s.MovieId)
                .WillCascadeOnDelete(false);
        }
    }
}
