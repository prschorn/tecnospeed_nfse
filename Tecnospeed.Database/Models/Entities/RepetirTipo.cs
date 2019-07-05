using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class RepetirTipo
  {
    [Index(IsUnique =true)]
    public int Id { get; set; }
    public string Nome { get; set; }

    public virtual IList<ContasReceber> ContasReceber { get; set; }
    public virtual IList<ContasPagar> ContasPagar { get; set; }
  }
}