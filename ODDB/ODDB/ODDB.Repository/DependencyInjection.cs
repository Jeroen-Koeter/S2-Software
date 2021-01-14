
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Repository.DBcontext;
using ODDB.Repository.Repositories;


namespace ODDB.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddTransient<IDrankRepository, DrankRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IBucketListRepository, BucketListRepository>();
            return services;
        }
    }
}
