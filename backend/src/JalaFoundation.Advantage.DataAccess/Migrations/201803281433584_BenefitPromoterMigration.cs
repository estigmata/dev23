// <auto-generated/>
namespace JalaFoundation.Advantage.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BenefitPromoterMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Model = c.String(nullable: false, unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Benefits",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150, unicode: false),
                        Description = c.String(nullable: false, maxLength: 300, unicode: false),
                        Status = c.Boolean(nullable: false),
                        BannerID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banners", t => t.BannerID, cascadeDelete: true)
                .Index(t => t.BannerID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        Phone = c.Int(),
                        Email = c.String(maxLength: 320, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promoters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200, unicode: false),
                        ImageID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        UserID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Images", t => t.ImageID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ImageID)
                .Index(t => t.CategoryID)
                .Index(t => t.ContactID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Promoters", "UserID", "dbo.Users");
            DropForeignKey("dbo.Promoters", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Promoters", "ContactID", "dbo.Contacts");
            DropForeignKey("dbo.Promoters", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Benefits", "BannerID", "dbo.Banners");
            DropIndex("dbo.Promoters", new[] { "UserID" });
            DropIndex("dbo.Promoters", new[] { "ContactID" });
            DropIndex("dbo.Promoters", new[] { "CategoryID" });
            DropIndex("dbo.Promoters", new[] { "ImageID" });
            DropIndex("dbo.Benefits", new[] { "BannerID" });
            DropTable("dbo.Promoters");
            DropTable("dbo.Contacts");
            DropTable("dbo.Categories");
            DropTable("dbo.Benefits");
            DropTable("dbo.Banners");
        }
    }
}
