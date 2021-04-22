using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class ClassesMap:EntityTypeConfiguration<Classes>
    {
        public ClassesMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.ClassName).HasMaxLength(5)
                .HasColumnType("nvarchar");

            this.ToTable("Classes");
        }
    }
}
