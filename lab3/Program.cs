using lab3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Program
    {

        public static int Main()
        {

           
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddDbContext<Context_DB>();
            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();

            //builder.services.adddbcontext<Context_DB>();
            app.MapControllerRoute("lab3", "{controller}/{action}");

            

            app.UseStaticFiles();
            app.Run();

            return 0;


            
        }
    }
}
