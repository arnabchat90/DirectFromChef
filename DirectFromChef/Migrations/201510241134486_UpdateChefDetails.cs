namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateChefDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CookingTimes", "ChefDetails_Id", c => c.Int());
            CreateIndex("dbo.CookingTimes", "ChefDetails_Id");
            AddForeignKey("dbo.CookingTimes", "ChefDetails_Id", "dbo.ChefDetails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CookingTimes", "ChefDetails_Id", "dbo.ChefDetails");
            DropIndex("dbo.CookingTimes", new[] { "ChefDetails_Id" });
            DropColumn("dbo.CookingTimes", "ChefDetails_Id");
        }
    }
}
