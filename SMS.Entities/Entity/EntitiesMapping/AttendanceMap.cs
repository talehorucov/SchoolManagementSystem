using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class AttendanceMap:EntityTypeConfiguration<Attendances>
    {
        public AttendanceMap()
        {
            this.HasKey(a => a.Id);

            this.ToTable("Attendances");

            this.HasRequired(a => a.Students)
                .WithMany(a => a.Attendances)
                .HasForeignKey(s => s.StudentId);
            this.HasRequired(a => a.Subjects)
                .WithMany(a => a.Attendances)
                .HasForeignKey(s => s.SubjectId);
        }
    }
}
