using Tecnospeed.Database.Models.Entities;
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

    public virtual IDbSet<Cliente> Clientes { get; set; }
    public virtual IDbSet<Contato> Contatos { get; set; }
    public virtual IDbSet<TipoCliente> TiposCliente { get; set; }
    public virtual IDbSet<IndicadorInscEstadual> IndicadoresInscEstadual { get; set; }

    public virtual IDbSet<Categoria> Categorias { get; set; }
    public virtual IDbSet<CentroCusto> CentroCustos { get; set; }
    public virtual IDbSet<Conta> Contas { get; set; }
    public virtual IDbSet<ContasPagar> ContasPagar { get; set; }
    public virtual IDbSet<ContasReceber> ContasReceber { get; set; }
    public virtual IDbSet<Fornecedor> Fornecedores { get; set; }
    public virtual IDbSet<RepetirTipo> RepetirTipos { get; set; }
    public virtual IDbSet<TerminoVigencia> TerminoVigencias { get; set; }
    public virtual IDbSet<Produto> Produtos { get; set; }
    public virtual IDbSet<Item> Itens { get; set; }
    public virtual IDbSet<TipoPessoa> TiposPessoa { get; set; }
    public virtual IDbSet<Contrato> Contratos { get; set; }
    public virtual IDbSet<Nota> Notas { get; set; }


  }
}