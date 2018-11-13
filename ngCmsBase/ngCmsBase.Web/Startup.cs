using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Authorization;
using ngCmsBase.Data;
using ngCmsBase.Data.DAL;
using ngCmsBase.Service;
using ngCmsBase.Service.Authorization;
using ngCmsBase.Service.Blogs;

namespace ngCmsBase.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ngCmsDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("ngCmsConnectionString"), c => c.MigrationsAssembly("ngCmsBase.Web")));
            
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            var type = typeof(IngServiceBase);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
            foreach(var t in types)
            {
                services.AddTransient(t);
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
