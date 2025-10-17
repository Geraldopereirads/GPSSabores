using Dapper;
using Microsoft.Data.SqlClient;

namespace GPSSabores.Infrastructure.Migrations;
public static class DatabaseMigration
{
    public static void migrate(string connectionString)
    {

    }

    private static void EnsureDatabasecreated_SQLServer(string connectionString)
    {
        var connectionStringBuilder = new SqlConnectionStringBuilder(connectionString);

        var databaseName = connectionStringBuilder.InitialCatalog;

        connectionStringBuilder.Remove("Database");

        using var dbConnection = new SqlConnection(connectionStringBuilder.ConnectionString);

        var parameters = new DynamicParameters();
        parameters.Add("name", databaseName);

        var records = dbConnection.Query("SELECT * FROM sys.DATABASES WHERE name = @name", parameters);
        if (records.Any() == false)
            dbConnection.Execute($"CREATE DATABASE {databaseName}");
    }
}
