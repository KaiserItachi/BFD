using BFD.Proxy;
using BFD.Query;
using BFD.Services;
using BFD.Types;
using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BFD
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
            services.AddHttpClient();

            services.AddTransient<AccountDetailProxy, AccountDetailProxy>();
            services.AddTransient<AccountDetailService, AccountDetailService>();
            services.AddTransient<CashFlowProxy, CashFlowProxy>();
            services.AddTransient<CashFlowService, CashFlowService>();

            services.AddOptions()
                .Configure<AccountSummaryApiConfiguration>(Configuration.GetSection("OpenBankingAccountSummaryApi"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseGraphiQl("/graphql");
            app.UseMvc();
        }
    }
}
