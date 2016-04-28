namespace HKOWebMVC4.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfileInfoseperated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfileInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        JMBAG = c.String(),
                        Država = c.String(),
                        Grad = c.String(),
                        Adresa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "UserProfileInfo_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "UserProfileInfo_Id");
            AddForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes", "Id");
            DropColumn("dbo.AspNetUsers", "Ime");
            DropColumn("dbo.AspNetUsers", "Prezime");
            DropColumn("dbo.AspNetUsers", "JMBAG");
            DropColumn("dbo.AspNetUsers", "Država");
            DropColumn("dbo.AspNetUsers", "Grad");
            DropColumn("dbo.AspNetUsers", "Adresa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Adresa", c => c.String());
            AddColumn("dbo.AspNetUsers", "Grad", c => c.String());
            AddColumn("dbo.AspNetUsers", "Država", c => c.String());
            AddColumn("dbo.AspNetUsers", "JMBAG", c => c.String());
            AddColumn("dbo.AspNetUsers", "Prezime", c => c.String());
            AddColumn("dbo.AspNetUsers", "Ime", c => c.String());
            DropForeignKey("dbo.AspNetUsers", "UserProfileInfo_Id", "dbo.UserProfileInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "UserProfileInfo_Id" });
            DropColumn("dbo.AspNetUsers", "UserProfileInfo_Id");
            DropTable("dbo.UserProfileInfoes");
        }
    }
}
