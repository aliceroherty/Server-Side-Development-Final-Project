namespace Real_Estate_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadImageFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "UploadDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "UploadDateTime");
        }
    }
}
