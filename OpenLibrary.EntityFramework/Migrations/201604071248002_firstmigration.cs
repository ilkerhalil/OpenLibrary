namespace OpenLibrary.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Isbn = c.String(),
                        PublicationDate = c.DateTime(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Gender = c.Byte(),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EMailAddresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EMail = c.String(),
                        MemberId = c.Guid(nullable: false),
                        EMailAddressType = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.MemberAddresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MemberId = c.Guid(nullable: false),
                        IsDefaultContactAddress = c.Boolean(nullable: false),
                        AddressType = c.Byte(nullable: false),
                        Address = c.String(nullable: false),
                        City_Id = c.Guid(),
                        Country_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.City_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CityCode = c.String(),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CountryCode = c.String(),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MemberId = c.Guid(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MemberId = c.Guid(nullable: false),
                        Number = c.String(),
                        Description = c.String(),
                        AreaCode = c.String(),
                        PhoneNumberType = c.Byte(nullable: false),
                        IsDefaultContactNumber = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumbers", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Notes", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberAddresses", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberAddresses", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.MemberAddresses", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.EMailAddresses", "MemberId", "dbo.Members");
            DropIndex("dbo.PhoneNumbers", new[] { "MemberId" });
            DropIndex("dbo.Notes", new[] { "MemberId" });
            DropIndex("dbo.MemberAddresses", new[] { "Country_Id" });
            DropIndex("dbo.MemberAddresses", new[] { "City_Id" });
            DropIndex("dbo.MemberAddresses", new[] { "MemberId" });
            DropIndex("dbo.EMailAddresses", new[] { "MemberId" });
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Notes");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.MemberAddresses");
            DropTable("dbo.EMailAddresses");
            DropTable("dbo.Members");
            DropTable("dbo.Books");
        }
    }
}
