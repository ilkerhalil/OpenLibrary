namespace OpenLibrary.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "Number", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Phones", "Description", c => c.String(maxLength: 100));
            AlterColumn("dbo.Phones", "AreaCode", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "AreaCode", c => c.String());
            AlterColumn("dbo.Phones", "Description", c => c.String());
            AlterColumn("dbo.Phones", "Number", c => c.String());
        }
    }
}
