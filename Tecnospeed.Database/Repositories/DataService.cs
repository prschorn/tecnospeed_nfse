using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.Interfaces;

namespace Tecnospeed.Database.Repositories
{
  public class DataService
  {
    private readonly ITecnospeedDbContextFactory factory;
    public DataService(ITecnospeedDbContextFactory factory)
    {
      this.factory = factory;
    }

    protected async Task UsingDbContext(Func<ITecnospeedDbContext, Task> asyncAction)
    {
      using(var dbContext = this.factory.Create())
      {
        await asyncAction(dbContext);
      }
    }
  }
}
