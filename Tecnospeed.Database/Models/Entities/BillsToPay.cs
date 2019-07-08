using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class BillsToPay
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public int AccountId { get; set; }
    public DateTime EventDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Value { get; set; }
    public bool Repeat { get; set; }
    public int RepeatTypeId { get; set; }
    public int OccurrencesNumber { get; set; }

    public bool Paid { get; set; }
    public DateTime PaymentDate{ get; set; }
    public decimal Discount { get; set; }
    public decimal Taxes { get; set; }
    public decimal PaidValue { get; set; }
    public int ProviderId { get; set; }
    public int CosCenterId { get; set; }
    public string Observation { get; set; }

    //FKS
    public virtual Category Category { get; set; }
    public virtual Account Account { get; set; }
    public virtual RepeatType RepeatType { get; set; }
    public virtual CostCenter CostCenter { get; set; }
    public virtual Provider Provider { get; set; }
  }
}