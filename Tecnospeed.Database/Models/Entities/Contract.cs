using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Contract
  {
    public int Id { get; set; }
    public int ClientId { get; set; }
    public string Number { get; set; }
    public DateTime DateSold { get; set; }
    public int BillingDate { get; set; }
    public int ValidityEndId { get; set; }
    public DateTime DateEnd { get; set; }

    public string PaymentForm { get; set; }
    public string ComplementInfo { get; set; }
    public decimal LiquidValue { get; set; }
    public decimal TotalValye { get; set; }
    public decimal Discount { get; set; }


    public virtual Client Client { get; set; }
    public virtual ValidityEnd ValidityEnd { get; set; }
    public virtual IList<Product> Products { get; set; }
  }
}