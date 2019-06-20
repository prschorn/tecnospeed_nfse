using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tecnospeed.NFSE.Models
{
  public class RequestData
  {
    public DadosEmpresa DadosPrestador { get; set; } = new DadosEmpresa();
    public DadosEmpresa DadosTomador { get; set; } = new DadosEmpresa();
    //DISCRIMINAÇÃO SERVIÇO
    public string DiscriminacaoServico { get; set; }
    //valores
    public Valores Valores { get; set; } = new Valores();
    public DadosNota DadosNota { get; set; } = new DadosNota();
    public DadosPrestacao DadosPrestacao { get; set; } = new DadosPrestacao();
  }

  public class Valores
  {
    public double ValorServicos { get; set; }
    public double ValorDeducoes { get; set; }
    public double ValorBaseCalculo { get; set; }
    public double ValorLiquido { get; set; }

    //ALIQUOTAS
    public double AliqPis { get; set; }
    public double AliqCofins { get; set; }
    public double AliqIR { get; set; }
    public double AliqCSLL { get; set; }
    public double AliqINSS { get; set; }
    public double AliqISS { get; set; }

    //valores
    public double ValorPis { get; set; }
    public double ValorCofins { get; set; }
    public double ValorINSS { get; set; }
    public double ValorIR { get; set; }
    public double ValorCSLL { get; set; }
    public double ValorISS { get; set; }
    public double ValorIssRetidoFonte { get; set; }

    public double DescontoIncondicionado { get; set; }
    public double DescontoCondicionado { get; set; }

    public double OutrasRetencoes { get; set; }
    /// <summary>
    /// Se for CNPJ, setar para true, se for cpf, setar para false
    /// </summary>
    public bool ISS { get; set; }

  }

  public class DadosEmpresa
  {
    //Dados Prestador
    public string CNPJ { get; set; }
    public string Nome { get; set; }
    public string NomeFantasia { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Municipio { get; set; }
    public string codMunicipio { get; set; }
    public string UF { get; set; }
    public string Pais { get; set; }
    public string Bairro { get; set; }
    public string CEP { get; set; }
    public string InscMunicipal { get; set; }
  }

  public class DadosPrestacao
  {
    public string CodCidadePrestacao { get; set; }
    public string CodigoCnae { get; set; }
    public string MunicipioIncidencia { get; set; }
    public string CidadePrestacao { get; set; }
    public double CodigoItemListaServico { get; set; }
    public double CodigoTributacaoMunicipio { get; set; }
    public int OptanteSimplesNacional { get; set; }
    public int Incentivadorcultural { get; set; }
    public int RegimeEspecialTributacao { get; set; }
    public int IncentivoFiscal { get; set; }
    public int TipoTributacao { get; set; }
    public string Operacao { get; set; }


  }


  public class DadosNota
  {
    public int NumeroLote { get; set; }
    public string SituacaoNota { get; set; }
    public int TipoRps { get; set; }
    public int SerieRps { get; set; }
    public int NumeroRps { get; set; }
    public DateTime DataCompetencia { get; set; }
  }
}
