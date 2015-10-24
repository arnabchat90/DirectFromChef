namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCookingDays : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CookingDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Checked = c.Boolean(nullable: false),
                        ChefDetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChefDetails", t => t.ChefDetails_Id)
                .Index(t => t.ChefDetails_Id);
            
            AddColumn("dbo.ChefDetails", "CookingDaysSelected", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CookingDays", "ChefDetails_Id", "dbo.ChefDetails");
            DropIndex("dbo.CookingDays", new[] { "ChefDetails_Id" });
            DropColumn("dbo.ChefDetails", "CookingDaysSelected");
            DropTable("dbo.CookingDays");
        }
    }
}
