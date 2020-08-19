using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyABPProject.EntityFrameworkCore
{
    public static class MyABPProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyABPProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
