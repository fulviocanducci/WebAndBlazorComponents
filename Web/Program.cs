using Microsoft.EntityFrameworkCore;
using Web.Models;
using MudBlazor.Services;
namespace Web
{
   public class Program
   {
      public static void Main(string[] args)
      {
         WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
         builder.Services.AddMudServices();
         builder.Services.AddControllersWithViews();
         builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents(); // Ou WebAssembly se quiser
         builder.Services.AddDbContext<Db>(options =>
         {
            options.UseInMemoryDatabase("InMemoryDb");
         });
         WebApplication app = builder.Build();
         if (!app.Environment.IsDevelopment())
         {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
         }
         app.UseHttpsRedirection();
         app.UseStaticFiles();
         app.UseRouting();
         app.UseAuthorization();
         app.MapControllerRoute
         (
             name: "default",
             pattern: "{controller=Home}/{action=Index}/{id?}"
         );

         app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
         //app.MapRazorComponents().AddInteractiveServerRenderMode();         
         app.Run();
      }
   }
}
