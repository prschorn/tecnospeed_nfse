using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class ValidityEnd
  {
    public int Id { get; set; }
    public string Value { get; set; }

    public virtual IList<Contract> Contracts { get; set; }
  }
}