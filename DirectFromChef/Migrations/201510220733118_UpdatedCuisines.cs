namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCuisines : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuisinesModels", "Checked", c => c.Boolean(nullable: false));
       //     AlterColumn("dbo.ChefDetails", "AllCuisines", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
         //   AlterColumn("dbo.ChefDetails", "AllCuisines", c => c.String());
            DropColumn("dbo.CuisinesModels", "Checked");
        }
    }
}
