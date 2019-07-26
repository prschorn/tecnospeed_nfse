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
            return "formato%3Dtx2%0Apadrao%3DTecnoNFSe%0ACidade%3DMaringaPR%0AINCLUIR%0AIdLote%3D31%0ANumeroLote%3D8594%0ACpfCnpjRemetente%3D08187168000160%0AInscricaoMunicipalRemetente%3D8214100028%0ARazaoSocialRemetente%3DTecnospeed+TI%0AQuantidadeRps%3D1%0ACodigoCidadeRemetente%3D41%0ATransacao%3D1%0ADataInicio%3D2017-02-23%0AVersao%3D3.10%0AValorTotalServicos%3D1.00%0AValorTotalDeducoes%3D0%0AValorTotalBaseCalculo%3D1.00%0ASALVAR%0A%0AINCLUIRRPS%0ADataEmissao%3D2017-02-23%0AIdRps%3DR1%0ANumeroRps%3D1%0ASerieRps%3D953%0ATipoRps%3D1%0AOptanteSimplesNacional%3D2%0AIncentivadorCultural%3D1%0AExigibilidadeISS%3D1%0AIncentivoFiscal%3D2%0ASituacaoNota%3D1%0ATipoTributacao%3D1%0ANaturezaTributacao%3D1%0ARegimeEspecialTributacao%3D0%0A%0AValorServicos%3D30.00%0AValorDeducoes%3D0%0AValorPis%3D2.33%0AValorCofins%3D4.00%0AValorInss%3D0.00%0AValorIr%3D0.00%0AValorCsll%3D2.00%0AIssRetido%3D2%0AValorIss%3D3.00%0AValorIssRetido%3D3.50%0ABaseCalculo%3D0%0AValorLiquidoNfse%3D300.00%0ADescontoIncondicionado%3D0.00%0ADescontoCondicionado%3D0.00%0AAliquotaISS%3D3%0AAliquotaPIS%3D200%0AAliquotaCOFINS%3D200%0AAliquotaINSS%3D200%0AAliquotaIR%3D200%0AAliquotaCSLL%3D200%0ACodigoItemListaServico%3D0107%0ACodigoCnae%3D6611801%0ACodigoTributacaoMunicipio%3D4115200%0ADiscriminacaoServico%3DLicenciamento+de+Software.%0ACodigoCidadePrestacao%3D4115200%0ADescricaoCidadePrestacao%3DMARINGA%0A%0ACpfCnpjPrestador%3D08187168000160%0AInscricaoMunicipalPrestador%3D096650%0ARazaoSocialPrestador%3DTecnospeed+T.I.%0ADDDPrestador%3D44%0ATelefonePrestador%3D30284665%0A%0ACpfCnpjTomador%3D08114280956%0ARazaoSocialTomador%3DTeste+NFSe%0AInscricaoMunicipalTomador%3D%0AInscricaoEstadualTomador%3D%0ATipoLogradouroTomador%3DRUA%0AEnderecoTomador%3DJURANDA+MARIGUTTI%0ANumeroTomador%3D2946%0AComplementoTomador%3DEDF.+VILLA+MIX%0ATipoBairroTomador%3DJARDIM%0ABairroTomador%3DCENTRO%0ACodigoCidadeTomador%3D44%0ADescricaoCidadeTomador%3DMARINGA%0AUfTomador%3DPR%0ACepTomador%3D87015983%0ADDDTomador%3D044%0ATelefoneTomador%3D4430147841%0AEmailTomador%3D%0A%0APercentualDeduzir%3D0%0AQuantidadeServicos%3D1%0AValorUnitarioServico%3D30.00%0ASALVARRPS";
      return HttpUtility.UrlEncode(@"formato=tx2
padrao=TecnoNFSe
Cidade=PortoAlegreRS

INCLUIR
NumeroLote=1
CPFCNPJRemetente=18110449000178
InscricaoMunicipalRemetente=56713126
ValorTotalServicos=0.10
ValorTotalDeducoes=0.00
ValorTotalBaseCalculo=0.10
SALVAR


INCLUIRRPS
SituacaoNota=1
TipoRps=1
SerieRps=1
NumeroRps=5001
DataEmissao=2019-07-09T00:00:00
Competencia=2019-07-09
CpfCnpjPrestador=18110449000178
InscricaoMunicipalPrestador=56713126
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

CodigoItemListaServico=1.05
CodigoTributacaoMunicipio=10500200
CodigoCnae=
DiscriminacaoServico=SERVICOS DE RECEBIMENTO DE FATURAS

MunicipioIncidencia=4314902
CodigoCidadePrestacao=4314902
DescricaoCidadePrestacao=Porto Alegre


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
AliquotaISS=2.00
ValorIss=0.00
IssRetido=2
ValorISSRetido=0.00
ValorLiquidoNfse=0.10
SALVARRPS");

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
