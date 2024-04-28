using System;
using DataAccessLayer.EF.Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.EF
{
	public class RapidBlogContext: DbContext
	{
        public RapidBlogContext(DbContextOptions<RapidBlogContext> options) : base(options) { }

        public DbSet<Bookmark> Bookmarks { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}

