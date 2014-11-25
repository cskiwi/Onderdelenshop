namespace Onderdelenshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.osUser", "Username", c => c.String());
            AddColumn("dbo.osUser", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.osUser", "Email");
            DropColumn("dbo.osUser", "Username");
        }
    }
}
