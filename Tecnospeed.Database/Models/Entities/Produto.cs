using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Produto
  {
    [Index(IsUnique =true)]
    public int Id { get; set; }
    public string Nome { get; set; }

    public virtual IList<Item> Itens { get; set; }
    public virtual IList<Contrato> Contratos { get; set; }

  }
}