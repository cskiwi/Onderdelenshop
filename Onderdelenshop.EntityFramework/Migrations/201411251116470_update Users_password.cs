namespace Onderdelenshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers_password : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.osUser", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.osUser", "Password");
        }
    }
}
