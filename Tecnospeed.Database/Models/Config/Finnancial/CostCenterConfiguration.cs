﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiterateElephant.Common.Model;

namespace LiterateElephant.Data.Config.Finnancial
{
  internal class CostCenterConfiguration : EntityTypeConfiguration<CostCenter>
  {
    public CostCenterConfiguration(string schema)
    {
      ToTable("CostCenter", schema);
      Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    }
  }
}
