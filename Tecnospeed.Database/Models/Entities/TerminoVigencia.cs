using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class TerminoVigencia
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }
    public string Valor { get; set; }

    public virtual IList<Contrato> Contratos { get; set; }
  }
}