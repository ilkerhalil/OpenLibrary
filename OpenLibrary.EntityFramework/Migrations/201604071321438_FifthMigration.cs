namespace OpenLibrary.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MemberAddresses", newName: "BaseAddresses");
            DropIndex("dbo.BaseAddresses", new[] { "MemberId" });
            AddColumn("dbo.BaseAddresses", "FullAddress", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.BaseAddresses", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.BaseAddresses", "MemberId", c => c.Guid());
            AlterColumn("dbo.BaseAddresses", "IsDefaultContactAddress", c => c.Boolean());
            AlterColumn("dbo.BaseAddresses", "AddressType", c => c.Byte());
            CreateIndex("dbo.BaseAddresses", "MemberId");
            DropColumn("dbo.BaseAddresses", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BaseAddresses", "Address", c => c.String(nullable: false, maxLength: 100));
            DropIndex("dbo.BaseAddresses", new[] { "MemberId" });
            AlterColumn("dbo.BaseAddresses", "AddressType", c => c.Byte(nullable: false));
            AlterColumn("dbo.BaseAddresses", "IsDefaultContactAddress", c => c.Boolean(nullable: false));
            AlterColumn("dbo.BaseAddresses", "MemberId", c => c.Guid(nullable: false));
            DropColumn("dbo.BaseAddresses", "Discriminator");
            DropColumn("dbo.BaseAddresses", "FullAddress");
            CreateIndex("dbo.BaseAddresses", "MemberId");
            RenameTable(name: "dbo.BaseAddresses", newName: "MemberAddresses");
        }
    }
}
