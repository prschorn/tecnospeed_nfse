using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiterateElephant.Common.Model;

namespace Tecnospeed.Database.Models.Interfaces
{
  public interface ITecnospeedDbContext
  {
    Task<int> SaveChangesAsync();
    IDbSet<Client> Clients { get; set; }
    IDbSet<Contact> Contacts { get; set; }
    IDbSet<ClientType> ClientTypes { get; set; }
    IDbSet<IndicatorStateSub> IndicatorStateSubs { get; set; }
    IDbSet<Category> Categories { get; set; }
    IDbSet<CategoryAppearInside> CategoriesAppearInside { get; set; }
    IDbSet<CostCenter> CostCenters { get; set; }
    IDbSet<Account> Accounts { get; set; }
    IDbSet<BillsToPay> BillsToPay { get; set; }
    IDbSet<BillsToReceive> BillsToReceive { get; set; }
    IDbSet<Provider> Providers { get; set; }
    IDbSet<RepeatType> RepeatTypes { get; set; }
    IDbSet<ValidityEnd> ValidityEnds { get; set; }
    IDbSet<Product> Products { get; set; }
    IDbSet<Item> Items { get; set; }
    IDbSet<PersonType> PersonTypes { get; set; }
    IDbSet<Contract> Contracts { get; set; }
    IDbSet<Invoice> Invoices { get; set; }
    IDbSet<Service> Services { get; set;}
    IDbSet<ServiceType> ServiceTypes { get; set; }
  }
}
