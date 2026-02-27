using Domain_Forum.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InfraStructure_Forum_DB
{
    public class AppDBContext: DbContext
    {
        #region Tables
        public DbSet<Member> Members { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        #endregion

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Authomated Collection of DataBase Configuration*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
