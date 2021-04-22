using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class StudentsMessageMap:EntityTypeConfiguration<StudentsMessage>
    {
        public StudentsMessageMap()
        {
            this.HasKey(s => s.Id);

            this.ToTable("StudentsMessage");

            this.HasRequired(s => s.Students)
                .WithMany(s => s.StudentsMessages)
                .HasForeignKey(st => st.StudentId)
                .WillCascadeOnDelete(false);
            this.HasRequired(s => s.Messages)
                .WithMany(s => s.StudentsMessages)
                .HasForeignKey(m => m.MessageId)
                .WillCascadeOnDelete(false);
        }
    }
}
