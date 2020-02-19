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
using CasaDeShows.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CasaDeShows.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using CasaDeShows.Config;
using CasaDeShows.Areas.Identity.Users;

namespace CasaDeShows
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
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));
            
           
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddIdentity<AdminUser, IdentityRole>()
                .AddEntityFrameworkStores<AdminUserContext>()
                .AddDefaultTokenProviders();

            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Configuration.GetSection("TokenConfigurations"))
                    .Configure(tokenConfigurations);


            services.AddSingleton(tokenConfigurations);


            services.AddAuthentication(authOptions =>
            {
                //    authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; //se comentar funfa identity
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;

                //    // Valida a assinatura de um token recebido
                paramsValidation.ValidateIssuerSigningKey = true;

                //    // Verifica se um token recebido ainda é válido
                paramsValidation.ValidateLifetime = true;

                //    // Tempo de tolerância para a expiração de um token (utilizado
                //    // caso haja problemas de sincronismo de horário entre diferentes
                //    // computadores envolvidos no processo de comunicação)
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            //// Ativa o uso do token como forma de autorizar o acesso
            //// a recursos deste projeto
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Administrador", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });

            //services.AddAuthorization(options => options.AddPolicy("Administrador", policy => policy.RequireClaim("Admin", "True")));


            // "injeção de dependencia" ele passa o data service para toda a aplicação
            services.AddTransient<IDataService, DataService>();
            
            services.AddAuthorization(options => options.AddPolicy("Administrador", policy => policy.RequireClaim("Admin", "True")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            serviceProvider.GetService<IDataService>().InicializaDB();
        }
    }
}
