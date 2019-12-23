namespace StudentLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Documents", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Documents", "Author", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Documents", "Author", c => c.String());
            AlterColumn("dbo.Documents", "Title", c => c.String());
        }
    }
}
