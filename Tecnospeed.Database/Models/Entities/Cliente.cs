using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Cliente
  {
    [Index(IsUnique =true)]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TipoClienteId { get; set; }
    public bool Ativo { get; set; }
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public int IndicadorInscEstadualId { get; set; }
    public string InscMunicipal { get; set; }
    public string InscSuframa { get; set; }
    public bool OptanteSimples { get; set; }
    public string EmailPrincipal { get; set; }
    public string Telefone { get; set; }
    public string TelefoneCelular { get; set; }
    public DateTime DataFundacao { get; set; }
    public string CodigoCliente { get; set; }
    public string Observacoes { get; set; }

    //ENDEREÇO
    public string CEP { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }


    //FKS
    public virtual IndicadorInscEstadual IndicadorInscEstadual { get; set; }
    public virtual TipoCliente TipoCliente { get; set; }
    public virtual IList<Contato> Contatos { get; set; }
    public virtual IList<Contrato> Contratos { get; set; }

  }
}