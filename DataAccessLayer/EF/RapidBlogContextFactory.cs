using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace DataAccessLayer.EF
{
	public class RapidBlogContextFactory : IDesignTimeDbContextFactory<RapidBlogContext>
	{
        public RapidBlogContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=RapidBlog;Uid=root;";
            var optionsBuilder = new DbContextOptionsBuilder<RapidBlogContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new RapidBlogContext(optionsBuilder.Options);
        }
    }
}

