namespace Movify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsSubbedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubbedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubbedToNewsLetter");
        }
    }
}
