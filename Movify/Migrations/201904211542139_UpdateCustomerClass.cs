namespace Movify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerClass : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '12/03/1999' where Id = 1");
            Sql("UPDATE Customers SET Birthdate = '22/09/1997' where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
