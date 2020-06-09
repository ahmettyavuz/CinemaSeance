namespace Cinema.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Casts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 30, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MovieName = c.String(nullable: false, maxLength: 30, unicode: false),
                        MovieTypeNo = c.Int(nullable: false),
                        MovieTime = c.Int(nullable: false),
                        _3D = c.Boolean(name: "3D", nullable: false),
                        Year = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 30, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MovieId = c.Guid(nullable: false),
                        TheaterId = c.Guid(nullable: false),
                        SeanceId = c.Guid(nullable: false),
                        ShowDate = c.DateTime(nullable: false, storeType: "date"),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seances", t => t.SeanceId)
                .ForeignKey("dbo.Theaters", t => t.TheaterId)
                .ForeignKey("dbo.Movies", t => t.MovieId)
                .Index(t => t.MovieId)
                .Index(t => t.TheaterId)
                .Index(t => t.SeanceId);
            
            CreateTable(
                "dbo.Seances",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartTime = c.Time(nullable: false, precision: 7),
                        FinishTime = c.Time(nullable: false, precision: 7),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SeatSales",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TicketId = c.Guid(nullable: false),
                        SessionId = c.Guid(nullable: false),
                        SeatId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seats", t => t.SeatId)
                .ForeignKey("dbo.Sessions", t => t.SessionId)
                .ForeignKey("dbo.Tickets", t => t.TicketId)
                .Index(t => t.TicketId)
                .Index(t => new { t.SeatId, t.SessionId }, unique: true, name: "CompositeKey");
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SeatTypeNo = c.Int(nullable: false),
                        SeatNo = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SeatId = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Seats", t => t.SeatId)
                .Index(t => t.SeatId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                        Session_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessions", t => t.Session_Id)
                .Index(t => t.Session_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 30, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 30, unicode: false),
                        Password = c.String(nullable: false, maxLength: 30, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DirectorMovie",
                c => new
                    {
                        DirectorId = c.Guid(nullable: false),
                        MovieId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.DirectorId, t.MovieId })
                .ForeignKey("dbo.Directors", t => t.DirectorId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.DirectorId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.CastMovie",
                c => new
                    {
                        CastId = c.Guid(nullable: false),
                        MovieId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CastId, t.MovieId })
                .ForeignKey("dbo.Casts", t => t.CastId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.CastId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.CastMovie", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.CastMovie", "CastId", "dbo.Casts");
            DropForeignKey("dbo.Sessions", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Tickets", "Session_Id", "dbo.Sessions");
            DropForeignKey("dbo.Sessions", "TheaterId", "dbo.Theaters");
            DropForeignKey("dbo.SeatSales", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.SeatSales", "SessionId", "dbo.Sessions");
            DropForeignKey("dbo.Theaters", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.SeatSales", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Sessions", "SeanceId", "dbo.Seances");
            DropForeignKey("dbo.DirectorMovie", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.DirectorMovie", "DirectorId", "dbo.Directors");
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.CastMovie", new[] { "MovieId" });
            DropIndex("dbo.CastMovie", new[] { "CastId" });
            DropIndex("dbo.DirectorMovie", new[] { "MovieId" });
            DropIndex("dbo.DirectorMovie", new[] { "DirectorId" });
            DropIndex("dbo.Tickets", new[] { "Session_Id" });
            DropIndex("dbo.Theaters", new[] { "SeatId" });
            DropIndex("dbo.SeatSales", "CompositeKey");
            DropIndex("dbo.SeatSales", new[] { "TicketId" });
            DropIndex("dbo.Sessions", new[] { "SeanceId" });
            DropIndex("dbo.Sessions", new[] { "TheaterId" });
            DropIndex("dbo.Sessions", new[] { "MovieId" });
            DropTable("dbo.UserRole");
            DropTable("dbo.CastMovie");
            DropTable("dbo.DirectorMovie");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Tickets");
            DropTable("dbo.Theaters");
            DropTable("dbo.Seats");
            DropTable("dbo.SeatSales");
            DropTable("dbo.Seances");
            DropTable("dbo.Sessions");
            DropTable("dbo.Directors");
            DropTable("dbo.Movies");
            DropTable("dbo.Casts");
        }
    }
}
