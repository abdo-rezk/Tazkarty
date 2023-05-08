namespace Tazkarty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Movie_Actor", newName: "Actor_Movie");
            AlterColumn("dbo.Movie", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Price", c => c.String());
            RenameTable(name: "dbo.Actor_Movie", newName: "Movie_Actor");
        }
    }
}
