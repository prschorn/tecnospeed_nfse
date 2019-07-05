using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Contrato
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string Numero { get; set; }
    public DateTime DataVenda { get; set; }
    public int DiaCobranca { get; set; }
    public int TerminoVigenciaId { get; set; }
    public DateTime DataTermino { get; set; }

    public string FormaPagamento { get; set; }
    public string InformacoesComplementares { get; set; }
    public decimal TotalLiquido { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal Desconto { get; set; }


    public virtual Cliente Cliente { get; set; }
    public virtual TerminoVigencia TerminoVigencia { get; set; }
    public virtual IList<Produto> Produtos { get; set; }
  }
}