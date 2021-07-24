namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDob : DbMigration
    {
        public override void Up()
        {
            Sql("update customers set Dob = '1/1/1980' where id = 1024");
        }
        
        public override void Down()
        {
        }
    }
}
