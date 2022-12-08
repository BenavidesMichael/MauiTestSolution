using SQLite;

namespace MauiTest.Repository;

public class TableData
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
}
