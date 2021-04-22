using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class ExamResultsMap:EntityTypeConfiguration<ExamResult>
    {
        public ExamResultsMap()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Mark).IsRequired();

            this.ToTable("ExamResults");

            this.HasRequired(e => e.Students)
                .WithMany(e => e.ExamResults)
                .HasForeignKey(s => s.StudentId);
            this.HasRequired(e => e.ExamTypes)
                .WithMany(e => e.ExamResults)
                .HasForeignKey(g => g.ExamTypesId);
            this.HasRequired(e => e.Subjects)
                .WithMany(e => e.ExamResults)
                .HasForeignKey(s => s.SubjectId);
        }
    }
}
