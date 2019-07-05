using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Contato
  {
    [Index(IsUnique =true)]
    public int Id { get; set; }

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Cargo { get; set; }

    public virtual IList<Cliente> Clientes { get; set; }
  }
}