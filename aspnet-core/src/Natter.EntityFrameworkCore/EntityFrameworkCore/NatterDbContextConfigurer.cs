using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Natter.EntityFrameworkCore
{
    public static class NatterDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NatterDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NatterDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
