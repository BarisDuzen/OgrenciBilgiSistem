namespace OgrenciBilgiSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OgrenciIdIdentityYapp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci");
            DropPrimaryKey("dbo.tOgrenci");
            AlterColumn("dbo.tOgrenci", "ogrenciID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.tOgrenci", "ogrenciID");
            AddForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci", "ogrenciID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci");
            DropPrimaryKey("dbo.tOgrenci");
            AlterColumn("dbo.tOgrenci", "ogrenciID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.tOgrenci", "ogrenciID");
            AddForeignKey("dbo.tOgrenciDers", "ogrenciID", "dbo.tOgrenci", "ogrenciID", cascadeDelete: true);
        }
    }
}
