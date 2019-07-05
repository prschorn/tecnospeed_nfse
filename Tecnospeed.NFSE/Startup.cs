using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using Tecnospeed.Database.Models;
using Tecnospeed.Database.Models.Interfaces;
using Tecnospeed.Database.Repositories;
using Tecnospeed.Database.Repositories.Interfaces;
using Tecnospeed.NFSE.Models;
using Tecnospeed.NFSE.Models.Interfaces;

namespace Tecnospeed.NFSE
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
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      services.AddHttpClient();
      services.AddScoped<IAuthentication, Authentication>();
      services.AddScoped<INFSE, NFSEHandler>();

      //database interfaces
      services.AddScoped<INfseRepository, NfseRepository>();
      services.AddScoped<ITecnospeedDbContext, TecnospeedDbContext>();
      services.AddScoped<ITecnospeedDbContextFactory, TecnospeedDbContextFactory>();


      services.Configure<IISServerOptions>(options =>
      {
        options.AutomaticAuthentication = false;
      });

      //Add swagger documentation
      services.AddSwaggerGen(c => {
        c.SwaggerDoc("v1", new Info { Version = "v1", Title="Tecnospeed NFSE" });
      });

      //Get data from tecnospeed appsettings
      var tecnoData = new TecnospeedData();
      this.Configuration.GetSection("NFSE").Bind(tecnoData);
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
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();


      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tecnospeed.nfse api v1");
      });
    }
  }
}
