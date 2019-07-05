namespace Tecnospeed.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nota : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lote = c.String(),
                        Numero = c.String(),
                        DataGeracao = c.DateTime(nullable: false),
                        Status = c.String(),
                        Xml = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Notas", new[] { "Id" });
            DropTable("dbo.Notas");
        }
    }
}
