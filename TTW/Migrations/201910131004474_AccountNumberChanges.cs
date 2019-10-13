namespace TTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChanges : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Events");
            DropTable("dbo.Rankings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        PrevPosition = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        Player = c.String(),
                        Country = c.String(),
                        Gender = c.String(),
                        CountryAlfaCode = c.String(),
                        Continent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        Link = c.String(),
                        Dates = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
