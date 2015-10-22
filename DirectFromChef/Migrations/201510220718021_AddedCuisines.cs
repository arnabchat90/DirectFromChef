namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCuisines : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuisinesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ChefDetails_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChefDetails", t => t.ChefDetails_Id)
                .Index(t => t.ChefDetails_Id);
            
            AddColumn("dbo.ChefDetails", "AllCuisines", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuisinesModels", "ChefDetails_Id", "dbo.ChefDetails");
            DropIndex("dbo.CuisinesModels", new[] { "ChefDetails_Id" });
            DropColumn("dbo.ChefDetails", "AllCuisines");
            DropTable("dbo.CuisinesModels");
        }
    }
}
