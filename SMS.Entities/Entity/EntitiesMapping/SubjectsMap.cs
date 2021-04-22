using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class SubjectsMap : EntityTypeConfiguration<Subjects>
    {
        public SubjectsMap()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.SubjectName)
                .IsRequired()
                .HasMaxLength(50);

            this.ToTable("Subjects");

            this.HasMany(c => c.Classes)
                .WithMany(s => s.Subjects)
                .Map(cs =>
                {
                    cs.MapLeftKey("SubjectId");
                    cs.MapRightKey("ClassId");
                    cs.ToTable("SubjectClasses");
                });
        }
    }
}
