namespace CourseWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manyTomany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cargoes", "TrafficId", "dbo.Traffic");
            DropIndex("dbo.Cargoes", new[] { "TrafficId" });
            CreateTable(
                "dbo.TrafficCargoes",
                c => new
                    {
                        Traffic_Id = c.Int(nullable: false),
                        Cargo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Traffic_Id, t.Cargo_Id })
                .ForeignKey("dbo.Traffic", t => t.Traffic_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cargoes", t => t.Cargo_Id, cascadeDelete: true)
                .Index(t => t.Traffic_Id)
                .Index(t => t.Cargo_Id);
            
            DropColumn("dbo.Cargoes", "TrafficId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cargoes", "TrafficId", c => c.Int());
            DropForeignKey("dbo.TrafficCargoes", "Cargo_Id", "dbo.Cargoes");
            DropForeignKey("dbo.TrafficCargoes", "Traffic_Id", "dbo.Traffic");
            DropIndex("dbo.TrafficCargoes", new[] { "Cargo_Id" });
            DropIndex("dbo.TrafficCargoes", new[] { "Traffic_Id" });
            DropTable("dbo.TrafficCargoes");
            CreateIndex("dbo.Cargoes", "TrafficId");
            AddForeignKey("dbo.Cargoes", "TrafficId", "dbo.Traffic", "Id");
        }
    }
}
