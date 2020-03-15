using Microsoft.EntityFrameworkCore;

namespace efcore.dotnetcoders.demo
{
    public static class DatabaseData
    {
        public static readonly string ConnectionString = "Server=DESKTOP-U3KQOI2\\SQLEXPRESS;Database=efcore.dotnetcoders.demo;Trusted_Connection=True;";
        public static Context GetContext() => new Context(new DbContextOptionsBuilder().UseSqlServer(DatabaseData.ConnectionString).Options);
    }
}
