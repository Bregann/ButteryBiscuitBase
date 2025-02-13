using Microsoft.EntityFrameworkCore;

namespace ButteryBiscuitBase.Domain.Data.Database.Context
{
    public class SqliteContext : AppDbContext
    {
        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) { }
    }
}
