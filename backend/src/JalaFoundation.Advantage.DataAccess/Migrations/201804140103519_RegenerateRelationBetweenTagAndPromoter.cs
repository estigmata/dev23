// <auto-generated/>
namespace JalaFoundation.Advantage.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegenerateRelationBetweenTagAndPromoter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromoterSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PromoterId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Promoters", t => t.PromoterId, cascadeDelete: true)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.PromoterId)
                .Index(t => t.ScheduleId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.Int(nullable: false),
                        From = c.Time(nullable: false, precision: 7),
                        To = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PromoterTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PromoterID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Promoters", t => t.PromoterID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PromoterID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TemplateId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .ForeignKey("dbo.Templates", t => t.TemplateId, cascadeDelete: true)
                .Index(t => t.TemplateId)
                .Index(t => t.ScheduleId);
            
            AddColumn("dbo.Benefits", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Benefits", "Duration", c => c.Int());
            AddColumn("dbo.Categories", "Icon", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TemplateSchedules", "TemplateId", "dbo.Templates");
            DropForeignKey("dbo.TemplateSchedules", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.PromoterTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PromoterTags", "PromoterID", "dbo.Promoters");
            DropForeignKey("dbo.PromoterSchedules", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.PromoterSchedules", "PromoterId", "dbo.Promoters");
            DropIndex("dbo.TemplateSchedules", new[] { "ScheduleId" });
            DropIndex("dbo.TemplateSchedules", new[] { "TemplateId" });
            DropIndex("dbo.PromoterTags", new[] { "TagID" });
            DropIndex("dbo.PromoterTags", new[] { "PromoterID" });
            DropIndex("dbo.PromoterSchedules", new[] { "ScheduleId" });
            DropIndex("dbo.PromoterSchedules", new[] { "PromoterId" });
            DropColumn("dbo.Categories", "Icon");
            DropColumn("dbo.Benefits", "Duration");
            DropColumn("dbo.Benefits", "CreationDate");
            DropTable("dbo.TemplateSchedules");
            DropTable("dbo.Templates");
            DropTable("dbo.Tags");
            DropTable("dbo.PromoterTags");
            DropTable("dbo.Schedules");
            DropTable("dbo.PromoterSchedules");
        }
    }
}
