namespace Onderdelenshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestSeedingParts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.osParts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Int(),
                        Title = c.String(),
                        Description = c.String(),
                        State = c.Byte(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.osUser", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.osUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.osParts", "UserId", "dbo.osUser");
            DropIndex("dbo.osParts", new[] { "UserId" });
            DropTable("dbo.osUser");
            DropTable("dbo.osParts");
        }
    }
}
