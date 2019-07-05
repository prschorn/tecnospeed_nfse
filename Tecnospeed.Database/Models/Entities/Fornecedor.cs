using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tecnospeed.Database.Models.Entities
{
  public class Fornecedor
  {
    [Index(IsUnique = true)]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }

    //DADOS JURÍDICOS
    public int? TipoPessoaId { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string CNPJ { get; set; }
    public int? IndIndicadorInscEstadualId { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string RazaoSocial { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string InscricaoEstadual { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string InscricaoMunicipal { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Aniversario { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string IdentificadorEstrangeiro { get; set; }

    //ENDEREÇO
    [Required(AllowEmptyStrings =true)]
    public string Cep { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Endereco { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Numero { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Bairro { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Complemento { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Cidade { get; set; }

    //Contato
    [Required(AllowEmptyStrings =true)]
    public string TelefoneComercial { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Email { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string TelefoneResidencial { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Contato { get; set; }
    [Required(AllowEmptyStrings =true)]
    public string Celular { get; set; }

    public string Observacoes { get; set; }

    public virtual IList<ContasPagar> ContasPagar { get; set; }
    public virtual TipoPessoa TipoPessoa { get; set; }
    public virtual IndicadorInscEstadual IndicadorInscEstadual { get; set; }
  }
}