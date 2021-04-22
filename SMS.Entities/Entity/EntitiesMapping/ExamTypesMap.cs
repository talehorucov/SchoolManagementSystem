using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class ExamTypesMap:EntityTypeConfiguration<ExamTypes>
    {
        public ExamTypesMap()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(30);

            this.ToTable("ExamTypes");
        }
    }
}
