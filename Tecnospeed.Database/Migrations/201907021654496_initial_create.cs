namespace Tecnospeed.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.ContasPagars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CategoriaId = c.Int(nullable: false),
                        ContaId = c.Int(nullable: false),
                        DataCompetencia = c.DateTime(nullable: false),
                        DataVencimento = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Repetir = c.Boolean(nullable: false),
                        RepetirTipoId = c.Int(nullable: false),
                        NumOcorrencias = c.Int(nullable: false),
                        Pago = c.Boolean(nullable: false),
                        DataPagamento = c.DateTime(nullable: false),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Juros = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FornecedorId = c.Int(nullable: false),
                        CentroCustoId = c.Int(nullable: false),
                        Observacoes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.CentroCustoes", t => t.CentroCustoId, cascadeDelete: true)
                .ForeignKey("dbo.Fornecedors", t => t.FornecedorId, cascadeDelete: true)
                .ForeignKey("dbo.Contas", t => t.ContaId, cascadeDelete: true)
                .ForeignKey("dbo.RepetirTipoes", t => t.RepetirTipoId, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.ContaId)
                .Index(t => t.RepetirTipoId)
                .Index(t => t.FornecedorId)
                .Index(t => t.CentroCustoId);
            
            CreateTable(
                "dbo.CentroCustoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.ContasRecebers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CategoriaId = c.Int(nullable: false),
                        ContaId = c.Int(nullable: false),
                        DataCompetencia = c.DateTime(nullable: false),
                        DataVencimento = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Repetir = c.Boolean(nullable: false),
                        RepetirTipoId = c.Int(nullable: false),
                        NumOcorrencias = c.Int(nullable: false),
                        Recebido = c.Boolean(nullable: false),
                        DataRecebimento = c.DateTime(nullable: false),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Juros = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorRecebido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClienteId = c.Int(nullable: false),
                        CentroCustoId = c.Int(nullable: false),
                        Observacoes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.CentroCustoes", t => t.CentroCustoId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Contas", t => t.ContaId, cascadeDelete: true)
                .ForeignKey("dbo.RepetirTipoes", t => t.RepetirTipoId, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.ContaId)
                .Index(t => t.RepetirTipoId)
                .Index(t => t.ClienteId)
                .Index(t => t.CentroCustoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        TipoClienteId = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Cnpj = c.String(),
                        RazaoSocial = c.String(),
                        IndicadorInscEstadualId = c.Int(nullable: false),
                        InscMunicipal = c.String(),
                        InscSuframa = c.String(),
                        OptanteSimples = c.Boolean(nullable: false),
                        EmailPrincipal = c.String(),
                        Telefone = c.String(),
                        TelefoneCelular = c.String(),
                        DataFundacao = c.DateTime(nullable: false),
                        CodigoCliente = c.String(),
                        Observacoes = c.String(),
                        CEP = c.String(),
                        Endereco = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IndicadorInscEstaduals", t => t.IndicadorInscEstadualId, cascadeDelete: true)
                .ForeignKey("dbo.TipoClientes", t => t.TipoClienteId, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.TipoClienteId)
                .Index(t => t.IndicadorInscEstadualId);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        Cargo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        Numero = c.String(),
                        DataVenda = c.DateTime(nullable: false),
                        DiaCobranca = c.Int(nullable: false),
                        TerminoVigenciaId = c.Int(nullable: false),
                        DataTermino = c.DateTime(nullable: false),
                        FormaPagamento = c.String(),
                        InformacoesComplementares = c.String(),
                        TotalLiquido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.TerminoVigencias", t => t.TerminoVigenciaId, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.ClienteId)
                .Index(t => t.TerminoVigenciaId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Detalhes = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemId = c.Int(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Id, unique: true)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.TerminoVigencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.IndicadorInscEstaduals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        TipoPessoaId = c.Int(),
                        CNPJ = c.String(nullable: false),
                        IndIndicadorInscEstadualId = c.Int(),
                        RazaoSocial = c.String(nullable: false),
                        InscricaoEstadual = c.String(nullable: false),
                        InscricaoMunicipal = c.String(nullable: false),
                        Aniversario = c.String(nullable: false),
                        IdentificadorEstrangeiro = c.String(nullable: false),
                        Cep = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Numero = c.String(nullable: false),
                        Bairro = c.String(nullable: false),
                        Complemento = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        TelefoneComercial = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        TelefoneResidencial = c.String(nullable: false),
                        Contato = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        Observacoes = c.String(),
                        IndicadorInscEstadual_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IndicadorInscEstaduals", t => t.IndicadorInscEstadual_Id)
                .ForeignKey("dbo.TipoPessoas", t => t.TipoPessoaId)
                .Index(t => t.Id, unique: true)
                .Index(t => t.TipoPessoaId)
                .Index(t => t.IndicadorInscEstadual_Id);
            
            CreateTable(
                "dbo.TipoPessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.TipoClientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.RepetirTipoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.ContatoClientes",
                c => new
                    {
                        Contato_Id = c.Int(nullable: false),
                        Cliente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contato_Id, t.Cliente_Id })
                .ForeignKey("dbo.Contatoes", t => t.Contato_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id, cascadeDelete: true)
                .Index(t => t.Contato_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.ProdutoContratoes",
                c => new
                    {
                        Produto_Id = c.Int(nullable: false),
                        Contrato_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Produto_Id, t.Contrato_Id })
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Contratoes", t => t.Contrato_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Contrato_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContasRecebers", "RepetirTipoId", "dbo.RepetirTipoes");
            DropForeignKey("dbo.ContasPagars", "RepetirTipoId", "dbo.RepetirTipoes");
            DropForeignKey("dbo.ContasRecebers", "ContaId", "dbo.Contas");
            DropForeignKey("dbo.ContasPagars", "ContaId", "dbo.Contas");
            DropForeignKey("dbo.ContasRecebers", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "TipoClienteId", "dbo.TipoClientes");
            DropForeignKey("dbo.Fornecedors", "TipoPessoaId", "dbo.TipoPessoas");
            DropForeignKey("dbo.Fornecedors", "IndicadorInscEstadual_Id", "dbo.IndicadorInscEstaduals");
            DropForeignKey("dbo.ContasPagars", "FornecedorId", "dbo.Fornecedors");
            DropForeignKey("dbo.Clientes", "IndicadorInscEstadualId", "dbo.IndicadorInscEstaduals");
            DropForeignKey("dbo.Contratoes", "TerminoVigenciaId", "dbo.TerminoVigencias");
            DropForeignKey("dbo.Items", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.ProdutoContratoes", "Contrato_Id", "dbo.Contratoes");
            DropForeignKey("dbo.ProdutoContratoes", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.Contratoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ContatoClientes", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ContatoClientes", "Contato_Id", "dbo.Contatoes");
            DropForeignKey("dbo.ContasRecebers", "CentroCustoId", "dbo.CentroCustoes");
            DropForeignKey("dbo.ContasRecebers", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.ContasPagars", "CentroCustoId", "dbo.CentroCustoes");
            DropForeignKey("dbo.ContasPagars", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.ProdutoContratoes", new[] { "Contrato_Id" });
            DropIndex("dbo.ProdutoContratoes", new[] { "Produto_Id" });
            DropIndex("dbo.ContatoClientes", new[] { "Cliente_Id" });
            DropIndex("dbo.ContatoClientes", new[] { "Contato_Id" });
            DropIndex("dbo.RepetirTipoes", new[] { "Id" });
            DropIndex("dbo.Contas", new[] { "Id" });
            DropIndex("dbo.TipoClientes", new[] { "Id" });
            DropIndex("dbo.TipoPessoas", new[] { "Id" });
            DropIndex("dbo.Fornecedors", new[] { "IndicadorInscEstadual_Id" });
            DropIndex("dbo.Fornecedors", new[] { "TipoPessoaId" });
            DropIndex("dbo.Fornecedors", new[] { "Id" });
            DropIndex("dbo.IndicadorInscEstaduals", new[] { "Id" });
            DropIndex("dbo.TerminoVigencias", new[] { "Id" });
            DropIndex("dbo.Items", new[] { "Produto_Id" });
            DropIndex("dbo.Items", new[] { "Id" });
            DropIndex("dbo.Produtoes", new[] { "Id" });
            DropIndex("dbo.Contratoes", new[] { "TerminoVigenciaId" });
            DropIndex("dbo.Contratoes", new[] { "ClienteId" });
            DropIndex("dbo.Contratoes", new[] { "Id" });
            DropIndex("dbo.Contatoes", new[] { "Id" });
            DropIndex("dbo.Clientes", new[] { "IndicadorInscEstadualId" });
            DropIndex("dbo.Clientes", new[] { "TipoClienteId" });
            DropIndex("dbo.Clientes", new[] { "Id" });
            DropIndex("dbo.ContasRecebers", new[] { "CentroCustoId" });
            DropIndex("dbo.ContasRecebers", new[] { "ClienteId" });
            DropIndex("dbo.ContasRecebers", new[] { "RepetirTipoId" });
            DropIndex("dbo.ContasRecebers", new[] { "ContaId" });
            DropIndex("dbo.ContasRecebers", new[] { "CategoriaId" });
            DropIndex("dbo.ContasRecebers", new[] { "Id" });
            DropIndex("dbo.CentroCustoes", new[] { "Id" });
            DropIndex("dbo.ContasPagars", new[] { "CentroCustoId" });
            DropIndex("dbo.ContasPagars", new[] { "FornecedorId" });
            DropIndex("dbo.ContasPagars", new[] { "RepetirTipoId" });
            DropIndex("dbo.ContasPagars", new[] { "ContaId" });
            DropIndex("dbo.ContasPagars", new[] { "CategoriaId" });
            DropIndex("dbo.ContasPagars", new[] { "Id" });
            DropIndex("dbo.Categorias", new[] { "Id" });
            DropTable("dbo.ProdutoContratoes");
            DropTable("dbo.ContatoClientes");
            DropTable("dbo.RepetirTipoes");
            DropTable("dbo.Contas");
            DropTable("dbo.TipoClientes");
            DropTable("dbo.TipoPessoas");
            DropTable("dbo.Fornecedors");
            DropTable("dbo.IndicadorInscEstaduals");
            DropTable("dbo.TerminoVigencias");
            DropTable("dbo.Items");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Contatoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.ContasRecebers");
            DropTable("dbo.CentroCustoes");
            DropTable("dbo.ContasPagars");
            DropTable("dbo.Categorias");
        }
    }
}
