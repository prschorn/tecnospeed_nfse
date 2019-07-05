using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class ContasReceber
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }

    public string Descricao { get; set; }
    public int CategoriaId { get; set; }
    public int ContaId { get; set; }
    public DateTime DataCompetencia { get; set; }
    public DateTime DataVencimento { get; set; }
    public decimal Valor { get; set; }

    //REPETIÇÃO
    public bool Repetir { get; set; }
    public int RepetirTipoId { get; set; }
    public int NumOcorrencias { get; set; }

    //RECEBIDO
    public bool Recebido { get; set; }
    public DateTime DataRecebimento { get; set; }
    public decimal Desconto { get; set; }
    public decimal Juros { get; set; }
    public decimal ValorRecebido { get; set; }

    public int ClienteId { get; set; }
    public int CentroCustoId { get; set; }
    public string Observacoes { get; set; }

    //FKS
    public virtual Cliente Cliente { get; set; }
    public virtual Categoria Categoria { get; set; }
    public virtual Conta Conta { get; set; }
    public virtual RepetirTipo RepetirTipo { get; set; }
    public virtual CentroCusto CentroCusto { get; set; }


  }
}