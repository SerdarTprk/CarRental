namespace CarRental.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "UpDatedDate", c => c.DateTime());
            AddColumn("dbo.Users", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "MyProperty");
            DropColumn("dbo.Users", "UpDatedDate");
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Users", "IsDeleted");
        }
    }
}
