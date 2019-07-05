using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.Interfaces;

namespace Tecnospeed.Database.Models
{
  public class TecnospeedDbContextFactory : ITecnospeedDbContextFactory
  {
    public TecnospeedDbContext Create()
    {
      return new TecnospeedDbContext();
    }
  }
}
