namespace Real_Estate_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentID = c.Int(nullable: false, identity: true),
                        SIN = c.String(nullable: false, maxLength: 11),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        MiddleName = c.String(maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        DateOfBirth = c.DateTime(nullable: false),
                        StreetAddress = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 30),
                        Province = c.String(nullable: false, maxLength: 30),
                        PostalCode = c.String(nullable: false, maxLength: 6),
                        HomePhone = c.String(maxLength: 14),
                        CellPhone = c.String(maxLength: 14),
                        OfficePhone = c.String(maxLength: 14),
                        OfficeEmail = c.String(nullable: false, maxLength: 75),
                        LoggedInUsername = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.AgentID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        MiddleName = c.String(maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 75),
                        PhoneNumber = c.String(nullable: false, maxLength: 14),
                        StreetAddress = c.String(nullable: false, maxLength: 30),
                        City = c.String(nullable: false, maxLength: 30),
                        AgentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Agents");
        }
    }
}
