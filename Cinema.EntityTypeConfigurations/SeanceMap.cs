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
    public class SeanceMap:EntityTypeConfiguration<Seance>
    {
        public SeanceMap()
        {
            HasKey(s => s.Id);

            Property(s => s.StartTime)
                //.HasColumnType("time")
                .IsRequired();

            Property(s => s.FinishTime)
                //.HasColumnType("time")
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
            //Session
            HasMany(sc => sc.Sessions)
                .WithRequired(ss => ss.Seance)
                .HasForeignKey(ss => ss.SeanceId)
                .WillCascadeOnDelete(false);
        }
    }
}
