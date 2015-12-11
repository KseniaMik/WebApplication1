namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Opisanie", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Opisanie");
        }
    }
}
