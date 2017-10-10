namespace AcoRaf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLasServiceDateFieldToVehicleModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "LastServiceDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "LastServiceDate");
        }
    }
}
