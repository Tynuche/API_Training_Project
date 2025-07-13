
using ConsoleApp1.Repository;

namespace ConsoleApp1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductRepository, TestRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-1 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Use-1 2 \n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/nitish", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-3 1 \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Use-3 2 \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Request Complete \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from nitish \n");
            });
        }
    }
}
