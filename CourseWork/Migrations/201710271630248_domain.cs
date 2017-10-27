namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class domain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airplanes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 4000),
                        MaxDistance = c.Int(nullable: false),
                        Carrying = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Traffic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAirportFrom = c.Int(nullable: false),
                        IdAirportTo = c.Int(nullable: false),
                        IdAirplane = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Weight = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TrafficId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Traffic", t => t.TrafficId)
                .Index(t => t.TrafficId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cargoes", "TrafficId", "dbo.Traffic");
            DropIndex("dbo.Cargoes", new[] { "TrafficId" });
            DropTable("dbo.Cargoes");
            DropTable("dbo.Traffic");
            DropTable("dbo.Airports");
            DropTable("dbo.Airplanes");
        }
    }
}
