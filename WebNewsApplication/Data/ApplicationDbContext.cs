using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebNewsApplication.Models;

namespace WebNewsApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebNewsApplication.Models.Articles>? Articles { get; set; }
        public DbSet<WebNewsApplication.Models.Users>? Users { get; set; }
    }
}