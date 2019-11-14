namespace SEKKAT.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RayanDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MotDePasse = c.String(maxLength: 50),
                        Identifient = c.String(maxLength: 50),
                        Nom = c.String(maxLength: 50),
                        Prénom = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.jeuxes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 50),
                        Plateforme = c.String(),
                        possédé = c.Boolean(nullable: false),
                        échangeable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Réservation",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        reservé = c.Boolean(nullable: false),
                        clients_id = c.Int(),
                        jeu_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Clients", t => t.clients_id)
                .ForeignKey("dbo.jeuxes", t => t.jeu_ID)
                .Index(t => t.clients_id)
                .Index(t => t.jeu_ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        StockMagasin = c.Boolean(nullable: false),
                        StockUser = c.Boolean(nullable: false),
                        jeu_ID = c.Int(),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.jeuxes", t => t.jeu_ID)
                .Index(t => t.jeu_ID);
            
            CreateTable(
                "dbo.jeuxClients",
                c => new
                    {
                        jeux_ID = c.Int(nullable: false),
                        Client_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.jeux_ID, t.Client_id })
                .ForeignKey("dbo.jeuxes", t => t.jeux_ID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_id, cascadeDelete: true)
                .Index(t => t.jeux_ID)
                .Index(t => t.Client_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "jeu_ID", "dbo.jeuxes");
            DropForeignKey("dbo.Réservation", "jeu_ID", "dbo.jeuxes");
            DropForeignKey("dbo.Réservation", "clients_id", "dbo.Clients");
            DropForeignKey("dbo.jeuxClients", "Client_id", "dbo.Clients");
            DropForeignKey("dbo.jeuxClients", "jeux_ID", "dbo.jeuxes");
            DropIndex("dbo.jeuxClients", new[] { "Client_id" });
            DropIndex("dbo.jeuxClients", new[] { "jeux_ID" });
            DropIndex("dbo.Stocks", new[] { "jeu_ID" });
            DropIndex("dbo.Réservation", new[] { "jeu_ID" });
            DropIndex("dbo.Réservation", new[] { "clients_id" });
            DropTable("dbo.jeuxClients");
            DropTable("dbo.Stocks");
            DropTable("dbo.Réservation");
            DropTable("dbo.jeuxes");
            DropTable("dbo.Clients");
        }
    }
}
