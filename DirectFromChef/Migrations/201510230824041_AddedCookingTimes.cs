namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCookingTimes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CookingTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ChefDetails", "CookingTimeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChefDetails", "CookingTimeId");
            DropTable("dbo.CookingTimes");
        }
    }
}
