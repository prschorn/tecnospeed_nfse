using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Account
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual IList<BillsToReceive> BillsToReceive { get; set; }
    public virtual IList<BillsToPay> BillsToPay { get; set; }
  }
}