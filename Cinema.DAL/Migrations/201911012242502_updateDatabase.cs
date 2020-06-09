namespace Cinema.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Theaters", "SeatId", "dbo.Seats");
            DropIndex("dbo.Theaters", new[] { "SeatId" });
            AddColumn("dbo.Seats", "TheaterId", c => c.Guid(nullable: false));
            AddColumn("dbo.Theaters", "TheaterName", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Seats", "TheaterId");
            AddForeignKey("dbo.Seats", "TheaterId", "dbo.Theaters", "Id");
            DropColumn("dbo.Theaters", "SeatId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Theaters", "SeatId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Seats", "TheaterId", "dbo.Theaters");
            DropIndex("dbo.Seats", new[] { "TheaterId" });
            DropColumn("dbo.Theaters", "TheaterName");
            DropColumn("dbo.Seats", "TheaterId");
            CreateIndex("dbo.Theaters", "SeatId");
            AddForeignKey("dbo.Theaters", "SeatId", "dbo.Seats", "Id");
        }
    }
}
