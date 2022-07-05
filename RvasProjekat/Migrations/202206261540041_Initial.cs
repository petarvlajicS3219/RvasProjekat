namespace RvasProjekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PrviModelDrugiModels", "PrviModel_id", "dbo.PrviModels");
            DropForeignKey("dbo.PrviModelDrugiModels", "DrugiModel_id", "dbo.DrugiModels");
            DropIndex("dbo.PrviModelDrugiModels", new[] { "PrviModel_id" });
            DropIndex("dbo.PrviModelDrugiModels", new[] { "DrugiModel_id" });
            CreateTable(
                "dbo.Aranzmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        drzava = c.String(nullable: false),
                        grad = c.String(nullable: false),
                        cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        opis = c.String(nullable: false),
                        slika = c.String(nullable: false),
                        AranzmanTipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AranzmanTips", t => t.AranzmanTipId, cascadeDelete: true)
                .Index(t => t.AranzmanTipId);
            
            CreateTable(
                "dbo.AranzmanTips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pansion = c.String(nullable: false),
                        tip = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DodatniIzlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ime = c.String(),
                        opis = c.String(),
                        cena = c.Single(nullable: false),
                        AranzmanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aranzmen", t => t.AranzmanId, cascadeDelete: true)
                .Index(t => t.AranzmanId);
            
            CreateTable(
                "dbo.Rezervacijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOd = c.DateTime(nullable: false),
                        DateDo = c.DateTime(nullable: false),
                        AranzmanId = c.Int(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .ForeignKey("dbo.Aranzmen", t => t.AranzmanId, cascadeDelete: true)
                .Index(t => t.AranzmanId)
                .Index(t => t.ApplicationUserId);
            
            DropTable("dbo.DrugiModels");
            DropTable("dbo.PrviModels");
            DropTable("dbo.PrviModelDrugiModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PrviModelDrugiModels",
                c => new
                    {
                        PrviModel_id = c.Int(nullable: false),
                        DrugiModel_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PrviModel_id, t.DrugiModel_id });
            
            CreateTable(
                "dbo.PrviModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DrugiModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        prezime = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropForeignKey("dbo.Rezervacijas", "AranzmanId", "dbo.Aranzmen");
            DropForeignKey("dbo.Rezervacijas", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.DodatniIzlets", "AranzmanId", "dbo.Aranzmen");
            DropForeignKey("dbo.Aranzmen", "AranzmanTipId", "dbo.AranzmanTips");
            DropIndex("dbo.Rezervacijas", new[] { "ApplicationUserId" });
            DropIndex("dbo.Rezervacijas", new[] { "AranzmanId" });
            DropIndex("dbo.DodatniIzlets", new[] { "AranzmanId" });
            DropIndex("dbo.Aranzmen", new[] { "AranzmanTipId" });
            DropTable("dbo.Rezervacijas");
            DropTable("dbo.DodatniIzlets");
            DropTable("dbo.AranzmanTips");
            DropTable("dbo.Aranzmen");
            CreateIndex("dbo.PrviModelDrugiModels", "DrugiModel_id");
            CreateIndex("dbo.PrviModelDrugiModels", "PrviModel_id");
            AddForeignKey("dbo.PrviModelDrugiModels", "DrugiModel_id", "dbo.DrugiModels", "id", cascadeDelete: true);
            AddForeignKey("dbo.PrviModelDrugiModels", "PrviModel_id", "dbo.PrviModels", "id", cascadeDelete: true);
        }
    }
}
