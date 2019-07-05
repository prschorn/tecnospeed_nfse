using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class IndicadorInscEstadual
  {
    [Index(IsUnique =true)]
    public int Id { get; set; }
    public string Nome { get; set; }

    public virtual IList<Cliente> Clientes { get; set; }
    public virtual IList<Fornecedor> Fornecedores { get; set; }
  }
}