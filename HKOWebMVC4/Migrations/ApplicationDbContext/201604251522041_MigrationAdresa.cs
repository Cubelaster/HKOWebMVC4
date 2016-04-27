namespace HKOWebMVC4.Migrations.ApplicationDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAdresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Država", c => c.String());
            AddColumn("dbo.AspNetUsers", "Grad", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Grad");
            DropColumn("dbo.AspNetUsers", "Država");
        }
    }
}
