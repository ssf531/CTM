using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CTM.Authorization.Roles;
using CTM.Authorization.Users;
using CTM.MultiTenancy;

namespace CTM.EntityFrameworkCore
{
    public class CTMDbContext : AbpZeroDbContext<Tenant, Role, User, CTMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CTMDbContext(DbContextOptions<CTMDbContext> options)
            : base(options)
        {
        }
    }
}
