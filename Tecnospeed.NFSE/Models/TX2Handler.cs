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

      if (data == null)
      {
        throw new Exception("Dados inválidos para gerar nota, verifique sua requisição.");
      }
      return @"formato=tx2
padrao=TecnoNFSe
NomeCidade=

INCLUIR
NumeroLote=1
CPFCNPJRemetente=08187168000160
InscricaoMunicipalRemetente=081871680
ValorTotalServicos=0.10
ValorTotalDeducoes=0.00
ValorTotalBaseCalculo=0.10
SALVAR


INCLUIRRPS
SituacaoNota=1
TipoRps=1
SerieRps=1
NumeroRps=1
DataEmissao=2019-07-04T00:00:00
Competencia=2019-07-04
CpfCnpjPrestador=08187168000160
InscricaoMunicipalPrestador=081871680
RazaoSocialPrestador=TECNOSPEED TECNOLOGIA DA INFORMACAO
InscricaoEstadualPrestador=081871680
TipoLogradouroPrestador=Rua
EnderecoPrestador=Endereco Teste
NumeroPrestador=42
ComplementoPrestador=Complemento teste sem acento
TipoBairroPrestador=Bairro
BairroPrestador=Bairro testes
CodigoCidadePrestador=4115200
DescricaoCidadePrestador=Maringa
TelefonePrestador=00000000
EmailPrestador=emailtestes@gmail.com
CepPrestador=87020025


OptanteSimplesNacional=2
IncentivadorCultural=2
RegimeEspecialTributacao=0
NaturezaTributacao=0
IncentivoFiscal=2
TipoTributacao=6
ExigibilidadeISS=1
Operacao=A

CodigoItemListaServico=15.05
CodigoTributacaoMunicipio=15.05
CodigoCnae=
DiscriminacaoServico=SERVICOS DE RECEBIMENTO DE FATURAS

MunicipioIncidencia=4115200
CodigoCidadePrestacao=4115200
DescricaoCidadePrestacao=Maringa


CpfCnpjTomador=04002391086
RazaoSocialTomador=TECNOSPEED TECNOLOGIA DA INFORMACAO
InscricaoEstadualTomador=
InscricaoMunicipalTomador=
TipoLogradouroTomador=AVENIDA
EnderecoTomador=AVENIDA DUQUE DE CAXIAS
NumeroTomador=882
ComplementoTomador=SALA 909
BairroTomador=ZONA 7
CodigoCidadeTomador=4115200
DescricaoCidadeTomador=MARINGA
UfTomador=PR
CepTomador=87050111
PaisTomador=1058
DDDTomador=044
TelefoneTomador=99999999
EmailTomador=teste@tecnospeed.com.br


AliquotaPIS=0.00
AliquotaCOFINS=0.00
AliquotaINSS=0.00
AliquotaIR=0.00
AliquotaCSLL=0.00
ValorPIS=0.00
ValorCOFINS=0.00
ValorINSS=0.00
ValorIR=0.00
ValorCSLL=0.00
OutrasRetencoes=0.00
DescontoIncondicionado=0.00
DescontoCondicionado=0.00
ValorDeducoes=0.00


ValorServicos=0.10
BaseCalculo=0.10
AliquotaISS=5.8547
ValorIss=0.05
IssRetido=2
ValorISSRetido=0.00
ValorLiquidoNfse=0.10
SALVARRPS";

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
