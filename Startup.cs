using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Teste 1", 9.99m));
            livros.Add(new Livro("002", "Teste 2", 8.99m));
            livros.Add(new Livro("003", "Teste 3", 7.99m));

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    foreach (var livro in livros)
                    {
                        await context.Response.WriteAsync($"{livro.Codigo}" + " " + $"{livro.Nome}" +" "+ $"{livro.Preco.ToString("C")}\r\n");
                    }

                });
            });
        }
    }
}
