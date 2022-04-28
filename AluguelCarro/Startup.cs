using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.AcessoDados.Repositorios;
using AluguelCarro.Models;
using AluguelCarro.Servicos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AluguelCarro
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
           
            services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Conexao")));
            services.AddIdentity<Usuario, NiveisAcesso>().AddDefaultUI()
                .AddEntityFrameworkStores<Contexto>();

            //configuração cookie
            services.ConfigureApplicationCookie(opcoes =>
            {
                opcoes.Cookie.HttpOnly = true;
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(50);
                opcoes.LoginPath = "/Usuarios/Login";
                opcoes.SlidingExpiration = true;
            });

            //configuração senha de acesso
            services.Configure<IdentityOptions>(opcoes =>
            {
                opcoes.Password.RequireDigit = false;
                opcoes.Password.RequireLowercase = false;
                opcoes.Password.RequireNonAlphanumeric = false;
                opcoes.Password.RequireUppercase = false;
                opcoes.Password.RequiredLength = 6;
                opcoes.Password.RequiredUniqueChars = 1;
            });

            services.AddScoped<INivelAcessoRepositorio, NivelAcessoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IContaRepositorio, ContaRepositorio>();
            services.AddScoped<ICarroRepositorio, CarroRepositorio>();
            services.AddScoped<IAluguelRepositorio, AluguelRepositorio>();

            services.Configure<ConfiguracoesEmail>(Configuration.GetSection("ConfiguracoesEmail"));
            services.AddScoped<IEmail, Email>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            //gerenciamento de erros
            app.UseStatusCodePagesWithReExecute("/Erros/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Usuarios}/{action=Login}/{id?}");
            });
        }
    }
}
