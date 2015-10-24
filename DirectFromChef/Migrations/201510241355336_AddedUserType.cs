namespace DirectFromChef.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserType");
        }
    }
}
