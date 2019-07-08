using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Client
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ClientTypeId { get; set; }
    public bool Active { get; set; }
    public string Cnpj { get; set; }
    public string CorporateName { get; set; }
    public int IndicatorStateSubcId { get; set; }
    public string MunicipalSub { get; set; }
    public string SuframaSub { get; set; }
    public bool SimpleOpt { get; set; }
    public string EmailPrincipal { get; set; }
    public string Phone { get; set; }
    public string CellPhone { get; set; }
    public DateTime FoundationDate { get; set; }
    public string ClientCode { get; set; }
    public string Observation { get; set; }

    //ENDEREÇO
    public string ZipCode { get; set; }
    public string Address  { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string District { get; set; }
    public string City { get; set; }


    //FKS
    public virtual IndicatorStateSub IndicatorStateSubc { get; set; }
    public virtual ClientType ClientType { get; set; }
    public virtual IList<Contact> Contacts { get; set; }
    public virtual IList<Contract> Contracts { get; set; }

  }
}