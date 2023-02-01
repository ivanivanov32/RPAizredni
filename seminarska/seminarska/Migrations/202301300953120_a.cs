namespace seminarska.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Izpits",
                c => new
                    {
                        IzpitId = c.Int(nullable: false, identity: true),
                        IzpitIme = c.String(),
                        Ocena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IzpitId);
            
            CreateTable(
                "dbo.Predmets",
                c => new
                    {
                        PredmetId = c.Int(nullable: false, identity: true),
                        PredmetIme = c.String(),
                    })
                .PrimaryKey(t => t.PredmetId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        StudentName = c.String(),
                        Ime = c.String(nullable: false),
                        Starost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Predmets");
            DropTable("dbo.Izpits");
        }
    }
}
