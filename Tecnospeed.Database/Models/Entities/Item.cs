using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Item
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }

    public string Detalhes { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public decimal Subtotal { get; set; }
    public int ItemId { get; set; }

    public virtual Produto Produto { get; set; }

  }
}