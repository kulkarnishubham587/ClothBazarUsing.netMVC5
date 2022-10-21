namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImgURL", c => c.String());
            AddColumn("dbo.Products", "ImgURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImgURL");
            DropColumn("dbo.Categories", "ImgURL");
        }
    }
}
