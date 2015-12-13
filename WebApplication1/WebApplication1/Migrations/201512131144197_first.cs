namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.Movies", "Opisanie", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Opisanie", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
    }
}
