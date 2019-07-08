using System.Collections.Generic;

namespace LiterateElephant.Common.Model
{
  public class CategoryAppearInside
  {
    public int Id { get; set; }
    public string Description { get; set; }

    public virtual IList<Category> Categories { get; set; }
  }
}