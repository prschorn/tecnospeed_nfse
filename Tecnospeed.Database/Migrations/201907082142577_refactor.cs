namespace Tecnospeed.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillsToPays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        EventDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Repeat = c.Boolean(nullable: false),
                        RepeatTypeId = c.Int(nullable: false),
                        OccurrencesNumber = c.Int(nullable: false),
                        Paid = c.Boolean(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Taxes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaidValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProviderId = c.Int(nullable: false),
                        CosCenterId = c.Int(nullable: false),
                        Observation = c.String(),
                        CostCenter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .ForeignKey("dbo.CostCenters", t => t.CostCenter_Id)
                .ForeignKey("dbo.RepeatTypes", t => t.RepeatTypeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AccountId)
                .Index(t => t.RepeatTypeId)
                .Index(t => t.ProviderId)
                .Index(t => t.CostCenter_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        InsideOfId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryAppearInsides", t => t.InsideOfId, cascadeDelete: true)
                .Index(t => t.InsideOfId);
            
            CreateTable(
                "dbo.BillsToReceives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        DateEvent = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Repeat = c.Boolean(nullable: false),
                        RepeatTypeId = c.Int(nullable: false),
                        OccurrencesNumber = c.Int(nullable: false),
                        Received = c.Boolean(nullable: false),
                        DateReceived = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Taxes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReceivedValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientId = c.Int(nullable: false),
                        CostCenterId = c.Int(nullable: false),
                        Observation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.CostCenters", t => t.CostCenterId, cascadeDelete: true)
                .ForeignKey("dbo.RepeatTypes", t => t.RepeatTypeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AccountId)
                .Index(t => t.RepeatTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.CostCenterId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientTypeId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Cnpj = c.String(),
                        CorporateName = c.String(),
                        IndicatorStateSubcId = c.Int(nullable: false),
                        MunicipalSub = c.String(),
                        SuframaSub = c.String(),
                        SimpleOpt = c.Boolean(nullable: false),
                        EmailPrincipal = c.String(),
                        Phone = c.String(),
                        CellPhone = c.String(),
                        FoundationDate = c.DateTime(nullable: false),
                        ClientCode = c.String(),
                        Observation = c.String(),
                        ZipCode = c.String(),
                        Address = c.String(),
                        Number = c.String(),
                        Complement = c.String(),
                        District = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientTypes", t => t.ClientTypeId, cascadeDelete: true)
                .ForeignKey("dbo.IndicatorStateSubs", t => t.IndicatorStateSubcId, cascadeDelete: true)
                .Index(t => t.ClientTypeId)
                .Index(t => t.IndicatorStateSubcId);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Number = c.String(),
                        DateSold = c.DateTime(nullable: false),
                        BillingDate = c.Int(nullable: false),
                        ValidityEndId = c.Int(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        PaymentForm = c.String(),
                        ComplementInfo = c.String(),
                        LiquidValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalValye = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.ValidityEnds", t => t.ValidityEndId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ValidityEndId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(),
                        Quantity = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ItemId = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.ValidityEnds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IndicatorStateSubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PersonTypeId = c.Int(),
                        CNPJ = c.String(),
                        IndicatorStateSubId = c.Int(),
                        CorporateName = c.String(),
                        StateSubscription = c.String(),
                        MunicipalSubscription = c.String(),
                        Birthday = c.String(),
                        ForeignerIndicator = c.String(),
                        ZipCode = c.String(),
                        Address = c.String(),
                        Number = c.String(),
                        District = c.String(),
                        Complement = c.String(),
                        City = c.String(),
                        ComercialPhone = c.String(),
                        Email = c.String(),
                        HousePhone = c.String(),
                        Contact = c.String(),
                        CellPhone = c.String(),
                        Observation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IndicatorStateSubs", t => t.IndicatorStateSubId)
                .ForeignKey("dbo.PersonTypes", t => t.PersonTypeId)
                .Index(t => t.PersonTypeId)
                .Index(t => t.IndicatorStateSubId);
            
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CostCenters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepeatTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryAppearInsides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lot = c.String(),
                        Number = c.String(),
                        GenerationDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        Xml = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                        SellValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeId, cascadeDelete: true)
                .Index(t => t.ServiceTypeId);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactClients",
                c => new
                    {
                        Contact_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contact_Id, t.Client_Id })
                .ForeignKey("dbo.Contacts", t => t.Contact_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Contact_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.ProductContracts",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Contract_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Contract_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Contracts", t => t.Contract_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Contract_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Categories", "InsideOfId", "dbo.CategoryAppearInsides");
            DropForeignKey("dbo.BillsToReceives", "RepeatTypeId", "dbo.RepeatTypes");
            DropForeignKey("dbo.BillsToPays", "RepeatTypeId", "dbo.RepeatTypes");
            DropForeignKey("dbo.BillsToReceives", "CostCenterId", "dbo.CostCenters");
            DropForeignKey("dbo.BillsToPays", "CostCenter_Id", "dbo.CostCenters");
            DropForeignKey("dbo.BillsToReceives", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Providers", "PersonTypeId", "dbo.PersonTypes");
            DropForeignKey("dbo.Providers", "IndicatorStateSubId", "dbo.IndicatorStateSubs");
            DropForeignKey("dbo.BillsToPays", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.Clients", "IndicatorStateSubcId", "dbo.IndicatorStateSubs");
            DropForeignKey("dbo.Contracts", "ValidityEndId", "dbo.ValidityEnds");
            DropForeignKey("dbo.Items", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductContracts", "Contract_Id", "dbo.Contracts");
            DropForeignKey("dbo.ProductContracts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Contracts", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ContactClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.ContactClients", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.Clients", "ClientTypeId", "dbo.ClientTypes");
            DropForeignKey("dbo.BillsToReceives", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BillsToReceives", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.BillsToPays", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BillsToPays", "AccountId", "dbo.Accounts");
            DropIndex("dbo.ProductContracts", new[] { "Contract_Id" });
            DropIndex("dbo.ProductContracts", new[] { "Product_Id" });
            DropIndex("dbo.ContactClients", new[] { "Client_Id" });
            DropIndex("dbo.ContactClients", new[] { "Contact_Id" });
            DropIndex("dbo.Services", new[] { "ServiceTypeId" });
            DropIndex("dbo.Providers", new[] { "IndicatorStateSubId" });
            DropIndex("dbo.Providers", new[] { "PersonTypeId" });
            DropIndex("dbo.Items", new[] { "Product_Id" });
            DropIndex("dbo.Contracts", new[] { "ValidityEndId" });
            DropIndex("dbo.Contracts", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "IndicatorStateSubcId" });
            DropIndex("dbo.Clients", new[] { "ClientTypeId" });
            DropIndex("dbo.BillsToReceives", new[] { "CostCenterId" });
            DropIndex("dbo.BillsToReceives", new[] { "ClientId" });
            DropIndex("dbo.BillsToReceives", new[] { "RepeatTypeId" });
            DropIndex("dbo.BillsToReceives", new[] { "AccountId" });
            DropIndex("dbo.BillsToReceives", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "InsideOfId" });
            DropIndex("dbo.BillsToPays", new[] { "CostCenter_Id" });
            DropIndex("dbo.BillsToPays", new[] { "ProviderId" });
            DropIndex("dbo.BillsToPays", new[] { "RepeatTypeId" });
            DropIndex("dbo.BillsToPays", new[] { "AccountId" });
            DropIndex("dbo.BillsToPays", new[] { "CategoryId" });
            DropTable("dbo.ProductContracts");
            DropTable("dbo.ContactClients");
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.Services");
            DropTable("dbo.Invoices");
            DropTable("dbo.CategoryAppearInsides");
            DropTable("dbo.RepeatTypes");
            DropTable("dbo.CostCenters");
            DropTable("dbo.PersonTypes");
            DropTable("dbo.Providers");
            DropTable("dbo.IndicatorStateSubs");
            DropTable("dbo.ValidityEnds");
            DropTable("dbo.Items");
            DropTable("dbo.Products");
            DropTable("dbo.Contracts");
            DropTable("dbo.Contacts");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.Clients");
            DropTable("dbo.BillsToReceives");
            DropTable("dbo.Categories");
            DropTable("dbo.BillsToPays");
            DropTable("dbo.Accounts");
        }
    }
}
