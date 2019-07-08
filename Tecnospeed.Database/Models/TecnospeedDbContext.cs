using LiterateElephant.Common.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tecnospeed.Database.Models.Interfaces;
using System.Threading.Tasks;

namespace Tecnospeed.Database.Models
{
  public class TecnospeedDbContext: DbContext, ITecnospeedDbContext
  {
    public TecnospeedDbContext() : base("name=TecnospeedDbContext")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelbuilder)
    {

    }

    public virtual IDbSet<Client> Clients { get; set; }
    public virtual IDbSet<Contact> Contacts { get; set; }
    public virtual IDbSet<ClientType> ClientTypes { get; set; }
    public virtual IDbSet<IndicatorStateSub> IndicatorStateSubs { get; set; }
    public virtual IDbSet<Category> Categories { get; set; }
    public virtual IDbSet<CategoryAppearInside> CategoriesAppearInside { get; set; }
    public virtual IDbSet<CostCenter> CostCenters { get; set; }
    public virtual IDbSet<Account> Accounts { get; set; }
    public virtual IDbSet<BillsToPay> BillsToPay { get; set; }
    public virtual IDbSet<BillsToReceive> BillsToReceive { get; set; }
    public virtual IDbSet<Provider> Providers { get; set; }
    public virtual IDbSet<RepeatType> RepeatTypes { get; set; }
    public virtual IDbSet<ValidityEnd> ValidityEnds { get; set; }
    public virtual IDbSet<Product> Products { get; set; }
    public virtual IDbSet<Item> Items { get; set; }
    public virtual IDbSet<PersonType> PersonTypes  { get; set; }
    public virtual IDbSet<Contract> Contracts { get; set; }
    public virtual IDbSet<Invoice> Invoices { get; set; }
    public virtual IDbSet<Service> Services { get; set; }
    public virtual IDbSet<ServiceType> ServiceTypes { get; set; }


  }
}