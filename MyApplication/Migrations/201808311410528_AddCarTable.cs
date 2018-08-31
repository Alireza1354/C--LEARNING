namespace MyApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VIN = c.String(),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        StickerPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
