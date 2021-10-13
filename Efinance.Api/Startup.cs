using Efinance.Api.Logging;
using Efinance.Models.DataBase;
using Efinance.Repositories.Interfaces;
using Efinance.Repositories.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Efinance.Api
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



         
            #region Configuracao do scopo de duração do serviço de configuracao
            services.AddSingleton<IConfiguration>(Configuration);
            #endregion Configuracao do scopo de duração do serviço de configuracao

            #region Configuracao do serviço de connexao com banco de dados do dapper

            services.AddScoped<DbConexao>();
            #endregion Configuracao do serviço de connexao com banco de dados do dapper


            #region Configuração dos serviços de repositorios
            services.AddTransient<ICidadeService, CidadeService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IEstadoService, EstadoService>();
            #endregion Configuração dos serviços de repositorios



            #region Configuracao do cors e politica de acesso
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
            #endregion Configuracao do cors e politica de acesso

            #region formatar saida do json 

            services.AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);  // saida como pascal case comente a linha caso queira camel case

            #endregion


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Efinance.Api",
                    Version = "v1"
                    //TermsOfService = "Não aplicável",
                    //Contact = new Contact
                    //{
                    //    Name = "Wladimilson",
                    //    Email = "contato@treinaweb.com.br",
                    //    Url = "https://treinaweb.com.br"
                    //},
                    //License = new License
                    //{
                    //    Name = "CC BY",
                    //    Url = "https://creativecommons.org/licenses/by/4.0"
                    //}
                });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Efinance.Api v1"));
            }

            #region Configuracao do provedor de log interno do .net
            loggerFactory.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration { LogLevel = LogLevel.Information }));
            #endregion Configuracao do provedor de log interno do .net


            app.UseCors("EnableCORS");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
