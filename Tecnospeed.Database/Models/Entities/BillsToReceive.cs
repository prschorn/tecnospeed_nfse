using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class BillsToReceive
  {
    public int Id { get; set; }

    public string Description { get; set; }
    public int CategoryId { get; set; }
    public int AccountId { get; set; }
    public DateTime DateEvent { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Value { get; set; }

    //REPETIÇÃO
    public bool Repeat { get; set; }
    public int RepeatTypeId { get; set; }
    public int OccurrencesNumber { get; set; }

    //RECEBIDO
    public bool Received { get; set; }
    public DateTime DateReceived { get; set; }
    public decimal Discount { get; set; }
    public decimal Taxes { get; set; }
    public decimal ReceivedValue { get; set; }

    public int ClientId { get; set; }
    public int CostCenterId { get; set; }
    public string Observation { get; set; }

    //FKS
    public virtual Client Client { get; set; }
    public virtual Category Category { get; set; }
    public virtual Account Account { get; set; }
    public virtual RepeatType RepeatType { get; set; }
    public virtual CostCenter CostCenter { get; set; }


  }
}