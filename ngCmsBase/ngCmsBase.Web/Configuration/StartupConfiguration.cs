using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ngCmsBase.Core.Data;
using ngCmsBase.Data;
using ngCmsBase.Data.DAL;
using ngCmsBase.Domain;
using ngCmsBase.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngCmsBase.Web.Configuration
{
    public static class StartupConfiguration
    {
        private static void RegisterInjectedInterfaces(Type injectableType, IServiceCollection services)
        {
            var type = injectableType;
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
            foreach (var t in types)
            {
                services.AddTransient(t);
            }

        }

        public static void InitDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ngCmsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ngCmsConnectionString"), c => c.MigrationsAssembly("ngCmsBase.Web")));

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            RegisterInjectedInterfaces(typeof(IngServiceBase), services);
            RegisterInjectedInterfaces(typeof(IngManagerBase), services);

        }
    }
}
