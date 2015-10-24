namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInCookingTimes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChefDetails", "CookingTimings", c => c.String(nullable: false));
            DropColumn("dbo.ChefDetails", "CookingTimeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChefDetails", "CookingTimeId", c => c.Int(nullable: false));
            DropColumn("dbo.ChefDetails", "CookingTimings");
        }
    }
}
