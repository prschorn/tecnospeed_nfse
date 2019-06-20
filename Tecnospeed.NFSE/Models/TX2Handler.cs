using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Tecnospeed.NFSE.Extensions;

namespace Tecnospeed.NFSE.Models
{
  public class TX2Handler
  {

    public static string GenerateTx2FromData(RequestData data)
    {
      if(data == null)
      {
        throw new Exception("Dados inválidos para gerar nota, verifique sua requisição.");
      }
      var tx2 = $@"
formato=tx2
padrao=TecnoNFSe
NomeCidade=

INCLUIR
NumeroLote={data.DadosNota.NumeroLote}
CPFCNPJRemetente={TecnospeedData.cnpj}
InscricaoMunicipalRemetente={TecnospeedData.inscMunicipal}
ValorTotalServicos={data.Valores.ValorServicos}
ValorTotalDeducoes={data.Valores.ValorDeducoes}
ValorTotalBaseCalculo={data.Valores.ValorBaseCalculo}
SALVAR


INCLUIRRPS
SituacaoNota={data.DadosNota.SituacaoNota}
TipoRps={data.DadosNota.TipoRps}
SerieRps={data.DadosNota.SerieRps}
NumeroRps={data.DadosNota.NumeroRps}
DataEmissao={DateTime.Now.DatabaseTime()}
Competencia={data.DadosNota.DataCompetencia.DatabaseTime()}
CpfCnpjPrestador={data.DadosPrestador.CNPJ}
InscricaoMunicipalPrestador={data.DadosPrestador.InscMunicipal}
RazaoSocialPrestador={data.DadosPrestador.Nome}
TipoLogradouroPrestador=Rua
EnderecoPrestador={data.DadosPrestador.Endereco}
NumeroPrestador={data.DadosPrestador.Numero}
ComplementoPrestador={data.DadosPrestador.Complemento}
TipoBairroPrestador=Bairro
BairroPrestador={data.DadosPrestador.Bairro}
CodigoCidadePrestador={data.DadosPrestador.codMunicipio}
DescricaoCidadePrestador={data.DadosPrestador.Municipio}
CepPrestador={data.DadosPrestador.CEP}


OptanteSimplesNacional={data.DadosPrestacao.OptanteSimplesNacional}
IncentivadorCultural={data.DadosPrestacao.Incentivadorcultural}
RegimeEspecialTributacao={data.DadosPrestacao.RegimeEspecialTributacao}
NaturezaTributacao={data.DadosPrestacao.OptanteSimplesNacional}
IncentivoFiscal={data.DadosPrestacao.IncentivoFiscal}
TipoTributacao={data.DadosPrestacao.TipoTributacao}
ExigibilidadeISS={(data.Valores.ISS?1:0)}
Operacao={data.DadosPrestacao.Operacao}

CodigoItemListaServico={data.DadosPrestacao.CodigoItemListaServico}
CodigoTributacaoMunicipio={data.DadosPrestacao.CodigoTributacaoMunicipio}
CodigoCnae={data.DadosPrestacao.CodigoCnae}
DiscriminacaoServico={data.DiscriminacaoServico}

MunicipioIncidencia={data.DadosPrestacao.MunicipioIncidencia}
CodigoCidadePrestacao={data.DadosPrestacao.CodCidadePrestacao}
DescricaoCidadePrestacao={data.DadosPrestacao.CidadePrestacao}


CpfCnpjTomador={data.DadosTomador.CNPJ}
RazaoSocialTomador={data.DadosTomador.Nome}
InscricaoMunicipalTomador={data.DadosTomador.InscMunicipal}
TipoLogradouroTomador=Rua
EnderecoTomador={data.DadosTomador.Endereco}
NumeroTomador={data.DadosTomador.Numero}
ComplementoTomador={data.DadosTomador.Complemento}
BairroTomador={data.DadosTomador.Bairro}
CodigoCidadeTomador={data.DadosTomador.codMunicipio}
DescricaoCidadeTomador={data.DadosTomador.Municipio}
UfTomador={data.DadosTomador.UF}
CepTomador={data.DadosTomador.CEP}
PaisTomador={data.DadosTomador.Pais}

AliquotaPIS={data.Valores.AliqPis}
AliquotaCOFINS={data.Valores.AliqCofins}
AliquotaINSS={data.Valores.AliqINSS}
AliquotaIR={data.Valores.AliqIR}
AliquotaCSLL={data.Valores.AliqCSLL}
ValorPIS={data.Valores.ValorPis}
ValorCOFINS={data.Valores.ValorCofins}
ValorINSS={data.Valores.ValorINSS}
ValorIR={data.Valores.ValorIR}
ValorCSLL={data.Valores.ValorCSLL}
OutrasRetencoes={data.Valores.OutrasRetencoes}
DescontoIncondicionado={data.Valores.DescontoIncondicionado}
DescontoCondicionado={data.Valores.DescontoCondicionado}
ValorDeducoes={data.Valores.ValorDeducoes}


ValorServicos={data.Valores.ValorServicos}
BaseCalculo={data.Valores.ValorBaseCalculo}
AliquotaISS={data.Valores.AliqISS}
ValorIss={data.Valores.ValorISS}
IssRetido={(data.Valores.ValorIssRetidoFonte > 0 ? 1 : 2 )}
ValorISSRetido={data.Valores.ValorIssRetidoFonte}
ValorLiquidoNfse={data.Valores.ValorLiquido}
SALVARRPS";

      return HttpUtility.UrlEncode(tx2);
    }
  }
}
