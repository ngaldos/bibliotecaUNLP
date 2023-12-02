using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorios;

public class BibliotecaCreadorDB
{
    public void AsegurarCreacionDB()
    {
        using var db = new BibliotecaContext();
        db.Database.EnsureCreated();
        var connection = db.Database.GetDbConnection();
        connection.Open();
        using (var command = connection.CreateCommand())
        {
            command.CommandText = "PRAGMA journal_mode=DELETE;";
            command.ExecuteNonQuery();
        }

    }
}