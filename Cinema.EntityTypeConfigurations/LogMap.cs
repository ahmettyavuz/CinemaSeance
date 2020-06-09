using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTypeConfigurations
{
    public class LogMap: EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            HasKey(l => l.Id);

            Property(l=>l.TabloType)
                .HasColumnName("TabloType")
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();
            Property(l => l.NewData)
                .HasColumnName("NewData")
                .IsUnicode(false)
                .IsOptional();
            Property(l=>l.OldData)
                .HasColumnName("OldData")
                .IsUnicode(false)
                .IsOptional();
            Property(l => l.DateTime)
                .HasColumnName("DateTime")
                .HasColumnType("datetime")
                .IsRequired();
            Property(l => l.UserId)
                .HasColumnName("UserId")
                .IsRequired();
        }
    }
}
