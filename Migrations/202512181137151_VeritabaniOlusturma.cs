namespace OgrenciBilgiSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeritabaniOlusturma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tBolum",
                c => new
                    {
                        bolumID = c.Int(nullable: false, identity: true),
                        bolumAd = c.String(nullable: false, maxLength: 100),
                        fakulteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bolumID)
                .ForeignKey("dbo.tFakulte", t => t.fakulteID, cascadeDelete: true)
                .Index(t => t.fakulteID);
            
            CreateTable(
                "dbo.tFakulte",
                c => new
                    {
                        fakulteID = c.Int(nullable: false, identity: true),
                        fakulteAd = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.fakulteID);
            
            CreateTable(
                "dbo.tOgrenci",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false),
                        ad = c.String(nullable: false, maxLength: 50),
                        soyad = c.String(nullable: false, maxLength: 50),
                        bolumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ogrenciID)
                .ForeignKey("dbo.tBolum", t => t.bolumID, cascadeDelete: true)
                .Index(t => t.bolumID);
            
            CreateTable(
                "dbo.tOgrenciDers",
                c => new
                    {
                        kayitID = c.Int(nullable: false, identity: true),
                        ogrenciID = c.Int(nullable: false),
                        dersID = c.Int(nullable: false),
                        yil = c.String(nullable: false, maxLength: 9),
                        yariyil = c.String(nullable: false, maxLength: 10),
                        vize = c.Int(),
                        final = c.Int(),
                    })
                .PrimaryKey(t => t.kayitID)
                .ForeignKey("dbo.tDers", t => t.dersID, cascadeDelete: true)
                .ForeignKey("dbo.tOgrenci", t => t.ogrenciID, cascadeDelete: true)
                .Index(t => t.ogrenciID)
                .Index(t => t.dersID);
            
            CreateTable(
                "dbo.tDers",
                c => new
                    {
                        dersID = c.Int(nullable: false, identity: true),
                        dersAd = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.dersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci");
            DropForeignKey("dbo.tOgrenciDers", "dersID", "dbo.tDers");
            DropForeignKey("dbo.tOgrenci", "bolumID", "dbo.tBolum");
            DropForeignKey("dbo.tBolum", "fakulteID", "dbo.tFakulte");
            DropIndex("dbo.tOgrenciDers", new[] { "dersID" });
            DropIndex("dbo.tOgrenciDers", new[] { "ogrenciID" });
            DropIndex("dbo.tOgrenci", new[] { "bolumID" });
            DropIndex("dbo.tBolum", new[] { "fakulteID" });
            DropTable("dbo.tDers");
            DropTable("dbo.tOgrenciDers");
            DropTable("dbo.tOgrenci");
            DropTable("dbo.tFakulte");
            DropTable("dbo.tBolum");
        }
    }
}
