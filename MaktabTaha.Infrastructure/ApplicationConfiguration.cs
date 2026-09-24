using MaktabTaha.Domain.Common;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MaktabTaha.Application.Profiles;

namespace MaktabTaha.Infrastructure
{
    public class ApplicationConfiguration
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            //services.AddAutoMapper(config =>{},typeof(ApplicationConfiguration).Assembly);
            services.AddAutoMapper(config => { }, typeof(GenericProfile));
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IUserPermissionRepository, UserPermissionRepository>();
            services.AddTransient<IInitialRequestRepository, InitialRequestRepository>();

            
            services.AddScoped<ITokenServices, TokenService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
