using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIrest.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace APIrest
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            
            string ChaveDeSeguranca = "eu_gosto_de_batata_e_lasagna"; // Chave de segurança
            var chaveSimetrica = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ChaveDeSeguranca));
            
            //define que sera usado a autenticação jwt
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
                // como o sistema deve ler o token
                options.TokenValidationParameters = new TokenValidationParameters{
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "Batata",
                    ValidAudience = "Pessoas_normais",
                    IssuerSigningKey = chaveSimetrica
                };
            });

            //swagger
            services.AddSwaggerGen(config => {
                config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo {Title = "API de produtos", Version = "v1"});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication(); // aplica o sistema de autenticação na aplicação

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger(config => {
                config.RouteTemplate = "doc/{documentName}/swagger.json";
            }); // gera um arquivo json // swagger.json
            app.UseSwaggerUI(config => {  // Views HTML do swagger
                config.SwaggerEndpoint("/doc/v1/swagger.json", "v1 docs");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
