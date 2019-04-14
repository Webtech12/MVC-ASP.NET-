namespace Movify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) Values (0, 0, 0)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) Values (30, 1, 10)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) Values (90, 3, 15)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) Values (300, 12, 20)");
        }

        
        
        public override void Down()
        {
        }
    }
}
