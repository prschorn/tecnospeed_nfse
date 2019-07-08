using System.Collections;
using System.Collections.Generic;

namespace LiterateElephant.Common.Model
{
  public class ServiceType
  {
    public int Id { get; set; }
    public string Description { get; set; }

    public virtual IList<Service> Services { get; set; }
  }
}