namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Images", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Images");
        }
    }
}
