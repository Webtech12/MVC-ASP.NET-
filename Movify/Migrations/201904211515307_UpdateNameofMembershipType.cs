namespace Movify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameofMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NameOfMembershipType = 'Pay As You Go' where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
