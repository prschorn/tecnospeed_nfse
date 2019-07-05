using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models.Entities;

namespace Tecnospeed.Database.Models.Interfaces
{
  public interface ITecnospeedDbContext
  {
    Task<int> SaveChangesAsync();
    IDbSet<Cliente> Clientes { get; set; }
    IDbSet<Contato> Contatos { get; set; }
    IDbSet<TipoCliente> TiposCliente { get; set; }
    IDbSet<IndicadorInscEstadual> IndicadoresInscEstadual { get; set; }
    IDbSet<Categoria> Categorias { get; set; }
    IDbSet<CentroCusto> CentroCustos { get; set; }
    IDbSet<Conta> Contas { get; set; }
    IDbSet<ContasPagar> ContasPagar { get; set; }
    IDbSet<ContasReceber> ContasReceber { get; set; }
    IDbSet<Fornecedor> Fornecedores { get; set; }
    IDbSet<RepetirTipo> RepetirTipos { get; set; }
    IDbSet<TerminoVigencia> TerminoVigencias { get; set; }
    IDbSet<Produto> Produtos { get; set; }
    IDbSet<Item> Itens { get; set; }
    IDbSet<TipoPessoa> TiposPessoa { get; set; }
    IDbSet<Contrato> Contratos { get; set; }
    IDbSet<Nota> Notas { get; set; }
  }
}
