namespace JobsWebApp_MVC5_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAnnotationsFromImageInTableJobs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "JobImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "JobImage", c => c.String(nullable: false));
        }
    }
}
