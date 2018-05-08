// <auto-generated/>
namespace JalaFoundation.Advantage.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoreModelAndRelationPromoter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        Phone = c.Int(),
                        Address = c.String(maxLength: 100, unicode: false),
                        PromoterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Promoters", t => t.PromoterID, cascadeDelete: true)
                .Index(t => t.PromoterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "PromoterID", "dbo.Promoters");
            DropIndex("dbo.Stores", new[] { "PromoterID" });
            DropTable("dbo.Stores");
        }
    }
}