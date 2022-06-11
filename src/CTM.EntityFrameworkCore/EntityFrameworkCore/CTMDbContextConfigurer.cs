using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CTM.EntityFrameworkCore
{
    public static class CTMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CTMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CTMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
