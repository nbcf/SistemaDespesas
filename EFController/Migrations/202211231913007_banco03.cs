namespace EFController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "DESCRICAO", c => c.String());
            DropTable("dbo.Movimentos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movimentos",
                c => new
                    {
                        ID_MOV = c.Int(nullable: false, identity: true),
                        TIPOMOV = c.String(),
                        VALOR = c.Double(nullable: false),
                        DATAMOVIMENTO = c.DateTime(),
                        HORAMOVIMENTO = c.String(),
                        IDCONTA = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_MOV);
            
            DropColumn("dbo.Contas", "DESCRICAO");
        }
    }
}
