namespace StudentLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_username : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Documents", "UserName", c => c.String());
        }
    }
}
