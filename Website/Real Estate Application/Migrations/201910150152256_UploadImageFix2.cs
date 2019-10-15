namespace Real_Estate_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadImageFix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Images", "FilePath", c => c.String());
            AlterColumn("dbo.Images", "FileName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "FileName", c => c.String(nullable: false, maxLength: 55));
            AlterColumn("dbo.Images", "FilePath", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
