using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Item
  {
    public int Id { get; set; }

    public string Details { get; set; }
    public int Quantity { get; set; }
    public decimal Value { get; set; }
    public decimal Subtotal { get; set; }
    public int ItemId { get; set; }

    public virtual Product Product { get; set; }

  }
}