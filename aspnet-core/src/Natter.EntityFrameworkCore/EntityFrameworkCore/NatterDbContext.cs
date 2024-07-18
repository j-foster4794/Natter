using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Natter.Authorization.Roles;
using Natter.Authorization.Users;
using Natter.MultiTenancy;
using Natter.NatterUsers;
using Natter.Posts;
using Natter.NatterPostInteractions;
using Natter.NatterInteractions;
using Natter.NatterMessages;
using Natter.NatterUserMessages;
namespace Natter.EntityFrameworkCore
{
    public class NatterDbContext : AbpZeroDbContext<Tenant, Role, User, NatterDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<NatterUser> NatterUsers { get; set; }

        public DbSet<NatterPost> NatterPosts { get; set; }

        public DbSet<NatterPostInteraction> NatterPostInteractions { get; set; }

        public DbSet<NatterInteraction> NatterInteractions { get; set; }

        public DbSet<NatterMessage> NatterMessages { get; set; }

        public DbSet<NatterUserMessage> NatterUserMessages { get; set; }
       
        public NatterDbContext(DbContextOptions<NatterDbContext> options)
            : base(options)
        {
        }
    }
}