

Database database = new Database();
bool connectionState = database + DatabaseType.PostgreSql;
Console.WriteLine(connectionState);

public class Database
{
  public static string _connectionString;

    public static bool operator +(Database database, DatabaseType databaseType)
    {
        _connectionString = databaseType switch
        {
            DatabaseType.SqlServer => "Data Source= yourServerAddress;Initial Catalog= yourDatabaseName;User ID= yourUsername;Password= yourPassword",
            DatabaseType.PostgreSql=> "Host = yourServerAddress;Port= 5432;Database= yourDatabaseName;Username= yourUsername;Password= yourPassword;",
            DatabaseType.Oracle=> "User Id=yourUsername;Password=yourPassword;Data Source=yourTnsOrConnectionString;",
            _ => throw new ArgumentException("Invalid database type"),
        };


        return true;


    }
}

enum DatabaseType
{
    SqlServer, Oracle, PostgreSql

}




