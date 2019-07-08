using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual IList<Item> Items { get; set; }
    public virtual IList<Contract> Contracts { get; set; }

  }
}