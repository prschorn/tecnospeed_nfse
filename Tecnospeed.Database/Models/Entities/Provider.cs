using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiterateElephant.Common.Model
{
  public class Provider
  {
    public int Id { get; set; }
    public string Name { get; set; }

    //DADOS JURÍDICOS
    public int? PersonTypeId { get; set; }
    public string CNPJ { get; set; }
    public int? IndicatorStateSubId { get; set; }
    public string CorporateName { get; set; }
    public string StateSubscription { get; set; }
    public string MunicipalSubscription { get; set; }
    public string Birthday { get; set; }
    public string ForeignerIndicator { get; set; }

    //ENDEREÇO
    public string ZipCode { get; set; }
    public string Address { get; set; }
    public string Number { get; set; }
    public string District { get; set; }
    public string Complement { get; set; }
    public string City { get; set; }

    //Contato
    public string ComercialPhone { get; set; }
    public string Email { get; set; }
    public string HousePhone { get; set; }
    public string Contact { get; set; }
    public string CellPhone { get; set; }

    public string Observation { get; set; }

    public virtual IList<BillsToPay> BillsToPay { get; set; }
    public virtual PersonType PersonType { get; set; }
    public virtual IndicatorStateSub IndicatorStateSub { get; set; }
  }
}