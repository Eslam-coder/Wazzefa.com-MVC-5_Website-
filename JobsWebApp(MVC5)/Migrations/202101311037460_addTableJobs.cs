namespace JobsWebApp_MVC5_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableJobs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false),
                        JobContent = c.String(nullable: false),
                        JobImage = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        JobsCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.JobsCategories", t => t.JobsCategory_ID)
                .Index(t => t.JobsCategory_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "JobsCategory_ID", "dbo.JobsCategories");
            DropIndex("dbo.Jobs", new[] { "JobsCategory_ID" });
            DropTable("dbo.Jobs");
        }
    }
}
