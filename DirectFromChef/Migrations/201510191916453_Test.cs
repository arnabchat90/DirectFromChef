namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChefDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUsersId = c.String(),
                        ChefExperience = c.String(nullable: false),
                        KitchenAddress = c.String(nullable: false),
                        KitchenLocation = c.String(nullable: false),
                        LatLng = c.String(),
                        ImgUrl = c.String(),
                        Rating = c.Int(nullable: false),
                        ApplicationUserChef_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserChef_Id)
                .Index(t => t.ApplicationUserChef_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChefDetails", "ApplicationUserChef_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ChefDetails", new[] { "ApplicationUserChef_Id" });
            DropTable("dbo.ChefDetails");
        }
    }
}
