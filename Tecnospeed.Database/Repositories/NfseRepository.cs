using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.DTOs;
using LiterateElephant.Common.Model;
using Tecnospeed.Database.Models.Interfaces;
using Tecnospeed.Database.Repositories.Interfaces;

namespace Tecnospeed.Database.Repositories
{
  public class NfseRepository : DataService, INfseRepository
  {
    public NfseRepository(ITecnospeedDbContextFactory dbFactory): base(dbFactory)
    {
    }
    public async Task SaveInformationAsync(NFSEDto data)
    {
      await this.UsingDbContext(async dbContext =>
      {
        try
        {
          var result = new Invoice
          {
            //TODO - ADICIONAR CAMPOS
          };
          dbContext.Invoices.Add(result);
          await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
          //TODO - VALIDAR ERRO
          throw new Exception("Erro ao salvar nota.");
        }
        
      });
    }
  }
}
