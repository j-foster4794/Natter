using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Natter.Authorization.Roles;
using Natter.Authorization.Users;
using Natter.MultiTenancy;

namespace Natter.EntityFrameworkCore
{
    public class NatterDbContext : AbpZeroDbContext<Tenant, Role, User, NatterDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NatterDbContext(DbContextOptions<NatterDbContext> options)
            : base(options)
        {
        }
    }
}
