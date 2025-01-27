using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using PowerCred.Models;

namespace PowerCred.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TaskDetails> TaskDetails { get; set; }
        public DbSet<Users> UserRegistration { get; set; }
    }
    }
