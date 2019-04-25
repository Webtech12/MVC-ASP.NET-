namespace Movify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id,Genre) Values (1,'Comedy')");
            Sql("Insert Into Genres (Id,Genre) Values (2,'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
