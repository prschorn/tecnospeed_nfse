using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class IndicatorStateSub
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual IList<Client> Clients { get; set; }
    public virtual IList<Provider> Providers{ get; set; }
  }
}