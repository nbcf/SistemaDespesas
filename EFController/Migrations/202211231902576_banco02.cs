namespace EFController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "DATA_ABERTURA", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contas", "DATA_ABERTURA");
        }
    }
}
