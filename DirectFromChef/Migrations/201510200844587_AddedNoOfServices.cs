namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNoOfServices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChefDetails", "NoOfServicesID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChefDetails", "NoOfServicesID");
        }
    }
}
