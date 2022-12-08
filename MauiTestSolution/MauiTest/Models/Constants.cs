using SQLite;

namespace MauiTest.Models
{
    public static class Constants
    {
        private const string DbFileName = "demoDB.db3";
        //Comportement sur le fichier
        //ReadWrite => kon puisse travailer sur la DB
        //Create => Cree la DB si elle n'existe pas.
        //Eviter les probleme multiThread
        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

        public static string DataBaseRoute { get => Path.Combine(FileSystem.AppDataDirectory, DbFileName); }

    }
}
