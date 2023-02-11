using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BShopWeb.Data.Interfaces;
using BShopWeb.Data.mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BShopWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)

        {

            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddTransient<IAllBooks, MockBooks>();

            services.AddTransient<IBooksCategory, MockCategory>();





        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

        {

            app.UseDeveloperExceptionPage();//Отображение ошибки

            app.UseStatusCodePages();// код страници ошибки

            app.UseStaticFiles();// статические ( картинки и т.д )

            app.UseMvcWithDefaultRoute(); // отслеживание Url address 



        }

    }

}
    

