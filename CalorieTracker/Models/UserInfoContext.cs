using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CalorieTracker.Models
{
    public class UserInfoContext : DbContext
    {
        public UserInfoContext(DbContextOptions<UserInfoContext> options)
            : base(options)
        {

        }
        public DbSet<UserInfo> UserInfos { get; set; } = null!; 
    }
}
