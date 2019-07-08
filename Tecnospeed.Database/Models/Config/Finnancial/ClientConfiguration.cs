using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiterateElephant.Common.Model;

namespace LiterateElephant.Data.Config.Finnancial
{
  internal class ClientConfiguration : EntityTypeConfiguration<Client>
  {
    public ClientConfiguration(string schema)
    {
      ToTable("Client", schema);
      Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    }
  }
}
