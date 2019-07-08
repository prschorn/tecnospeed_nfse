using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;
using LiterateElephant.Common.Model;

namespace Tecnospeed.Database.Repositories.Interfaces
{
  public interface INfseRepository
  {
    Task SaveInformationAsync(NFSEDto data);
  }
}
