using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiterateElephant.Common.Model
{
  public class Service
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public decimal SellValue { get; set; }
    public decimal CostValue { get; set; }
    public int ServiceTypeId { get; set; }

    public virtual ServiceType ServiceType { get; set; }
  }
}
