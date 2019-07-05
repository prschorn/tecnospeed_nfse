using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnospeed.Database.Models.Interfaces
{
  public interface ITecnospeedDbContextFactory : IDbContextFactory<TecnospeedDbContext>
  {
  }
}
