using communitybuilderapi.Data;
using communitybuilderapi.Helpers;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Repositories;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace communitybuilderapi
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
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("CommunityBuilder")));
            //services.Directories();

            //services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IBusinessRepository, BusinessRepository>();
            services.AddScoped<IVideoRepository, VideoRepository>();
            //services.AddScoped<IFanRepository, FanRepository>();
            //services.AddScoped<ILocalizationRepository, LocalizationRepository>();
            //services.AddScoped<IGenericLocalizationRepository, GenericLocalizationRepository>();
            //services.AddScoped<ISiteRepository, SiteRepository>();
            //services.AddScoped<IHeaderRepository, HeaderRepository>();
            ////services.AddScoped<ILocalizationRepository, LocalizationRepository>();
            //services.AddScoped<ICSSRepository, CSSRepository>();
            //services.AddScoped<IFileRepository, FileRepository>();
            services.AddSyncfusionBlazor();
            services.AddHttpContextAccessor();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyCommunityBuilder.API", Version = "v1" });
                c.SchemaFilter<EnumSchemaFilter>();

            });
            services.AddCors(options =>
            {
                options.AddPolicy("CorsApi",
                    builder => builder.WithOrigins("*")
                .AllowAnyHeader()
                .AllowAnyMethod());
            });

            services.Configure<FormOptions>(x =>
            {
                x.MultipartBodyLengthLimit = 600000000;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (!env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTMwOTAwQDMxMzkyZTMzMmUzMEVreTlQT2E5c0E0dkU2SE9zQlNrbllTc0I3cC8ybGFUcFFpbjZVcWZvcnM9");
            app.UseCors("CorsApi");
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyCommunityBuilder.API v1"));
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            lifetime.ApplicationStarted.Register(OnApplicationStartedAsync(env).Wait);
            string baseURL = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine(env.WebRootPath);
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //    Path.Combine(env.WebRootPath + @"/upload/images")),
            //    RequestPath = new PathString(env.WebRootPath + "/uplaod/images")
            //});

            //app.UseDirectoryBrowser(new DirectoryBrowserOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //Path.Combine(env.WebRootPath + @"/upload/images")),
            //    RequestPath = new PathString(env.WebRootPath + "/upload/images")
            //});

        }
        private async Task<Action> OnApplicationStartedAsync(IWebHostEnvironment env)
        {
            try
            {
                //var path0 = Path.Combine(env.WebRootPath, $"/upload/businesses/_a");
                //var path1 = Path.Combine(env.WebRootPath, $"/upload/modules");
                //var path2 = Path.Combine(env.WebRootPath, $"/upload/sites");

                //if (!Directory.Exists(path0))
                //{
                //    Directory.CreateDirectory(path0);
                //}
                //if (!Directory.Exists(path1))
                //{
                //    Directory.CreateDirectory(path1);
                //}
                //if (!Directory.Exists(path2))
                //{
                //    Directory.CreateDirectory(path2);
                //}


            }
            catch (Exception ex)
            {

                throw;
            }

            return null;
        }
    }
}