using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AmgSistemas.ControleMilhas.Api
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<Interfaces.IUsuarioRepository, Repository.UsuarioRepository>();
            services.AddScoped<Interfaces.IEmpresaRepository, Repository.EmpresaRepository>();
            services.AddScoped<Interfaces.IProgramaRepository, Repository.ProgramaRepository>();
            services.AddScoped<Interfaces.ICotacaoRepository, Repository.CotacaoRepository>();
            services.AddScoped<Interfaces.IMembroRepository, Repository.MembroRepository>();

            services.AddScoped<Interfaces.IUsuarioService, Service.UsuarioServices>();
            services.AddScoped<Interfaces.IEmpresaService, Service.EmpresaServices>();
            services.AddScoped<Interfaces.IProgramaService, Service.ProgramaServices>();
            services.AddScoped<Interfaces.ICotacaoServices, Service.CotacaoServices>();
            services.AddScoped<Interfaces.IMembroService, Service.MembroServices>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                                  });
            });


            services.AddDbContext<BD.BancoContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("DbContext")));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
