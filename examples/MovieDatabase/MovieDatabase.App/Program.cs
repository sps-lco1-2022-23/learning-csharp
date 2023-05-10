
// Tools > NuGet Pacakge Maanager > Console
// install-package Microsoft.Data.Sqlite 

using Microsoft.Data.Sqlite;

string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Downloads");
string filename = Path.Combine(path, "movies.db");

using (var connection = new SqliteConnection($"Data Source={filename.ToString()}"))
{
    connection.Open();
    var command = connection.CreateCommand();
    string director = "James%";
    command.CommandText =
    @"  select title, year 
        from movies 
        where director like $director
    ";
    command.Parameters.AddWithValue("$director", director);

    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            var title = reader.GetString(0);
            int year = reader.GetInt32(1);

            Console.WriteLine($"{title} was made in {year}!");
        }
    }

}

Console.ReadKey();