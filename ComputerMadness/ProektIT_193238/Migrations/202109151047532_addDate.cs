namespace ProektIT_193238.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "CurrentDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "CurrentDate");
        }
    }
}
