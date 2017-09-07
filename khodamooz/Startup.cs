using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.Extensions.Configuration;
using khodamooz.data;
using khodamooz.data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace khodamooz
{
  public class Startup
  {
    private IConfigurationRoot _config;

    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddEnvironmentVariables();

      _config = builder.Build();
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton(_config);
      services.AddDbContext<KhodamoozContext>(ServiceLifetime.Scoped);
      services.AddScoped<IKhodamoozRepository, KhodamoozRepository>();
      services.AddTransient<IdentityInitializer>();

      services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<KhodamoozContext>();
      services.AddAuthentication("MyCookieAuthenticationScheme")
        .AddCookie(options =>
        {
          options.AccessDeniedPath = "/Account/Forbidden/";
          options.LoginPath = "/Account/Unauthorized/";
        });

      ConfigureApplicationCookie(services);

      services.AddMvc();
    }

    private static void ConfigureApplicationCookie(IServiceCollection services)
    {

      services.ConfigureApplicationCookie(options =>
      {
        options.Events.OnRedirectToLogin = (ctx) =>
        {
          if (ctx.Request.Path.StartsWithSegments("/api") && ctx.Response.StatusCode == 200)
          {
            ctx.Response.StatusCode = 401;
          }
          return Task.CompletedTask;
        };

        options.Events.OnRedirectToAccessDenied = (ctx) =>
        {
          if (ctx.Request.Path.StartsWithSegments("/api") && ctx.Response.StatusCode == 200)
          {
            ctx.Response.StatusCode = 401;
          }
          return Task.CompletedTask;
        };

      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IdentityInitializer identitySeeder)
    {
      loggerFactory.AddConsole(_config.GetSection("Logging"));
      loggerFactory.AddDebug();
      loggerFactory.AddFile("Logs/khodamooz-{Date}-log.txt");

      app.Use(async (context, next) =>
      {
        await next();
        if (context.Response.StatusCode == 404 &&
           !Path.HasExtension(context.Request.Path.Value) &&
           !context.Request.Path.Value.StartsWith("/api/"))
        {
          context.Request.Path = "/index.html";
          await next();
        }
      });

      app.UseAuthentication();

      app.UseMvcWithDefaultRoute();
      app.UseDefaultFiles();
      app.UseStaticFiles();

      identitySeeder.Seed().Wait();
    }
  }
}
