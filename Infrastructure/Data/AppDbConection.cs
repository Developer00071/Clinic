namespace Infrastructure.Data;
using Npgsql;
using System.Data;
public class AppDbConection
{
    private string connectionString = "Host=localhost;Port=5432;Database=booknest;Username=postgres;Password=907708429";

    public IDbConnection Connection()=> new NpgsqlConnection(connectionString);
}

