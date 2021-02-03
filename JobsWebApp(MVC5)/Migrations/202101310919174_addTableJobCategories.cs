namespace JobsWebApp_MVC5_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableJobCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobsCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JobName = c.String(nullable: false),
                        JobDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobsCategories");
        }
    }
}
