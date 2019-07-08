using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  
  public class Category
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public int Type { get; set; }
    public int InsideOfId { get; set; }

    public virtual CategoryAppearInside InsideOf { get; set; }
    public virtual IList<BillsToReceive> BillsToReceive { get; set; }
    public virtual IList<BillsToPay> BillsToPay{ get; set; }


    public enum CategoryType
    {
      Expense,
      Receipt
    };
  }
}