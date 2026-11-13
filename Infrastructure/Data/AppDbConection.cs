namespace Infrastructure.Data;
using Npgsql;
using System.Data;
public class AppDbConection
{
    private string connectionString = "Host=localhost;Port=5432;Database=Clinic;Username=postgres;Password=0510";

    public IDbConnection Connection()=> new NpgsqlConnection(connectionString);
}

