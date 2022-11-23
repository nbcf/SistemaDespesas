namespace EFController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        ID_CONTAS = c.Int(nullable: false, identity: true),
                        NOME = c.String(),
                        BANCO = c.String(),
                        AGENCIA = c.String(),
                        NUMEROCONTA = c.String(),
                        DIGITO = c.String(),
                        SALDO = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CONTAS);
            
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movimentos");
            DropTable("dbo.Contas");
        }
    }
}
