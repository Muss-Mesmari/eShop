using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using eShop.Infrastructure.Database;
using eShop.Infrastructure;
using eShop.Infrastructure.Services;
using Microsoft.AspNetCore.Http.Features;
using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using eShop.Infrastructure.ModelBinding;
using eShop.Infrastructure.Rule.GeneralRules;
using eShop.Infrastructure.Rule.Membership;
using eShop.Infrastructure.DependencyInjection;
using eShop.Infrastructure.Middleware;

namespace eShop.Web
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
            services.AddDbContextPool<eShopDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));


           
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            }).AddDefaultUI().AddDefaultTokenProviders().AddEntityFrameworkStores<eShopDbContext>();



            // This filter is for binding that date that is coming .CSV files
            //services.AddMvc(options =>
            //{
            //    options.ModelBinderProviders.Insert(0, new CSVModelBinderProvider());
            //})
            //    .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);

            services.AddScoped<IFAQService, FAQService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IOrderService, OrderService>();


            services.AddConfiguration(Configuration);
            services.AddShoppingCart();
            services.AddRules();
            

            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {            
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseSession();
        app.UseRouting();

        app.UseMiddleware<FeatureSwitchMiddleware>();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
        });
    }
}
}
