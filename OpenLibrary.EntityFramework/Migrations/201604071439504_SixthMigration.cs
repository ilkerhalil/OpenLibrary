namespace OpenLibrary.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Members", newName: "People");
            RenameTable(name: "dbo.BaseAddresses", newName: "Addresses");
            DropForeignKey("dbo.EMailAddresses", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Notes", "MemberId", "dbo.Members");
            DropIndex("dbo.EMailAddresses", new[] { "MemberId" });
            DropIndex("dbo.Notes", new[] { "MemberId" });
            AddColumn("dbo.EMailAddresses", "Person_Id", c => c.Guid());
            AddColumn("dbo.Notes", "Person_Id", c => c.Guid());
            CreateIndex("dbo.EMailAddresses", "Person_Id");
            CreateIndex("dbo.Notes", "Person_Id");
            AddForeignKey("dbo.EMailAddresses", "Person_Id", "dbo.People", "Id");
            AddForeignKey("dbo.Notes", "Person_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Person_Id", "dbo.People");
            DropForeignKey("dbo.EMailAddresses", "Person_Id", "dbo.People");
            DropIndex("dbo.Notes", new[] { "Person_Id" });
            DropIndex("dbo.EMailAddresses", new[] { "Person_Id" });
            DropColumn("dbo.Notes", "Person_Id");
            DropColumn("dbo.EMailAddresses", "Person_Id");
            CreateIndex("dbo.Notes", "MemberId");
            CreateIndex("dbo.EMailAddresses", "MemberId");
            AddForeignKey("dbo.Notes", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EMailAddresses", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Addresses", newName: "BaseAddresses");
            RenameTable(name: "dbo.People", newName: "Members");
        }
    }
}
