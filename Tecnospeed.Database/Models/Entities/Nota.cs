using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnospeed.Database.Models.Entities
{
  public class Nota
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }

    public string Lote { get; set; }
    public string Numero { get; set; }
    public DateTime DataGeracao { get; set; }
    public string Status { get; set; }
    public string Xml { get; set; }
  }
}
