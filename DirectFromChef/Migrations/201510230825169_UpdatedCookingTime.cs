namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCookingTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CookingTimes", "Checked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CookingTimes", "Checked");
        }
    }
}
