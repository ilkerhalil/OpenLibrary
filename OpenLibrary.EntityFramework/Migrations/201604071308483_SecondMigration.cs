namespace OpenLibrary.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PhoneNumbers", newName: "Phones");
            AddColumn("dbo.Phones", "PhoneType", c => c.Byte(nullable: false));
            AlterColumn("dbo.MemberAddresses", "Address", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Phones", "PhoneNumberType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "PhoneNumberType", c => c.Byte(nullable: false));
            AlterColumn("dbo.MemberAddresses", "Address", c => c.String(nullable: false));
            DropColumn("dbo.Phones", "PhoneType");
            RenameTable(name: "dbo.Phones", newName: "PhoneNumbers");
        }
    }
}
