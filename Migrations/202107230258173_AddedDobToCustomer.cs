namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDobToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Dob", c => c.DateTime());
        }
        
        public override void Down()
        {
        }
    }
}
