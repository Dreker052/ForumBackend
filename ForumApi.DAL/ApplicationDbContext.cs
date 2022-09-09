using Microsoft.EntityFrameworkCore;
using ForumApi.Domain.Entities;

namespace ForumApi.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Post> Posts { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Reply> Replies { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-37E8R7D;Initial Catalog=forumdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}