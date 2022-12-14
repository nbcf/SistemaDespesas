namespace EFController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BancoVersao01 : DbMigration
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
                        DATA_ABERTURA = c.DateTime(),
                        DESCRICAO = c.String(),
                    })
                .PrimaryKey(t => t.ID_CONTAS);
            
            CreateTable(
                "dbo.Movimentos",
                c => new
                    {
                        ID_MOVIMENTO = c.Int(nullable: false, identity: true),
                        DESCRICAO = c.String(),
                        TIPOMOV = c.String(),
                        DATAMOV = c.DateTime(),
                        VALOR = c.Double(nullable: false),
                        IDCONTA = c.Int(),
                    })
                .PrimaryKey(t => t.ID_MOVIMENTO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movimentos");
            DropTable("dbo.Contas");
        }
    }
}
