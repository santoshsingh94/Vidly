namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Hangover', 5, '01/01/2015', '01/05/2015',5,5)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Die Hard', 1, '01/01/2013', '01/05/2013',5,5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('The Terminator', 1, '01/01/2016', '01/05/2016',5,5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Toy Story', 3, '01/01/2017', '01/05/2017',5,5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Titanic', 4, '01/01/2014', '01/05/2014',5,5)");
        }
        
        public override void Down()
        {
        }
    }
}
