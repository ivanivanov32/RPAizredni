namespace SeminarskaNalogaIvan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Predmetis",
                c => new
                    {
                        PredmetiId = c.Int(nullable: false, identity: true),
                        PredmetiName = c.String(),
                        Oceni = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PredmetiId);
            
            CreateTable(
                "dbo.Studentis",
                c => new
                    {
                        StudentiId = c.Int(nullable: false, identity: true),
                        StudentiName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentiId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Studentis");
            DropTable("dbo.Predmetis");
        }
    }
}
