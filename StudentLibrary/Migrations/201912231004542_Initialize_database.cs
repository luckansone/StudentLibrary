namespace StudentLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        UserName = c.String(nullable:false, defaultValue:"admin"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Documents");
        }
    }
}
