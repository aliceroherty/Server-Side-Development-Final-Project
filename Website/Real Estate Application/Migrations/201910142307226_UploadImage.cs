namespace Real_Estate_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        FilePath = c.String(nullable: false, maxLength: 255),
                        FileName = c.String(nullable: false, maxLength: 55),
                        Description = c.String(nullable: false, maxLength: 255),
                        AlternativeText = c.String(nullable: false, maxLength: 30),
                        StaffMemberID = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Images");
        }
    }
}
