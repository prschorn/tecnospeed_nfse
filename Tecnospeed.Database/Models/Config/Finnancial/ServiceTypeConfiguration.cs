using LiterateElephant.Common.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnospeed.Database.Models.Config.Finnancial
{
  internal class ServiceTypeConfiguration: EntityTypeConfiguration<ServiceType>
  {
    public ServiceTypeConfiguration(string schema)
    {
      ToTable("ServiceType", schema);
      Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    }
  }
}
