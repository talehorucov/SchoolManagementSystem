using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities.Entity.EntitiesMapping
{
    public class RolesMap: EntityTypeConfiguration<Roles>
    {
        public RolesMap()
        {
            this.HasKey(r => r.Id);

            this.Property(r => r.RoleName)
                .IsRequired()
                .HasMaxLength(30);

            this.ToTable("Roles");
        }
    }
}
