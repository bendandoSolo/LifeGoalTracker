namespace LifeGoalTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dayModelEdited : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ADay = c.DateTime(nullable: false),
                        Pompodoros = c.Int(nullable: false),
                        Cigarettes = c.Int(nullable: false),
                        StrongCigarettes = c.Int(nullable: false),
                        Exercise = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Days");
        }
    }
}
