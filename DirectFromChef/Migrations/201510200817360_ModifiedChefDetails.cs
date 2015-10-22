namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedChefDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChefDetails", "ChefKindID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChefDetails", "ChefKindID");
        }
    }
}
