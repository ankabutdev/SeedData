namespace SeedData;

public class DbConstans
{
    public const string DB_HOST = "localhost";
    public const string DB_PORT = "5432";
    public const string DB_DATABASE = "GMDB";
    public const string DB_USER = "postgres";
    public const string DB_PASSWORD = "Ankabut";

    public const string DB_CONNECTIONSTRING = $"Host={DB_HOST};" +
        $"Port={DB_PORT};" +
        $"User ID={DB_USER};" +
        $"Password={DB_PASSWORD}; " +
        $"Database={DB_DATABASE};";
}
