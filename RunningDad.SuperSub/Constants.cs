using SQLite;

namespace RunningDad.SuperSub;

public static class Constants
{
    private const string DBFileName = "RunningDad.SuperSub.db3";

    public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

    public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, DBFileName);
}