using FrontBack2.DAL;
using Microsoft.EntityFrameworkCore;

namespace FrontBack2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            app.UseHttpsRedirection();
            app.Run();
        }
    }
}