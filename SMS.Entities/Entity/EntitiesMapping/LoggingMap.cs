using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity
{
    public class LoggingMap : EntityTypeConfiguration<Logging>
    {
        public LoggingMap()
        {
            this.HasKey(l => l.Id);

            this.Property(l => l.Message)
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            this.ToTable("Logging");

            this.HasOptional(l => l.Staffs)
                .WithMany(l => l.Logging)
                .HasForeignKey(s => s.StaffId)
                .WillCascadeOnDelete(false);
            this.HasOptional(l => l.Students)
                .WithMany(l => l.Logging)
                .HasForeignKey(s => s.StudentId)
                .WillCascadeOnDelete(false);
        }
    }
}
