using MajasPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //framework to enable MVC

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //creates request whilst and only whilst being used

builder.Services.AddScoped<IPieRepository, PieRepository>();



builder.Services.AddDbContext<MajasPieShopDbContext>(options => //Connection string to DB 
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:MajasPieShopDbContextConnection"]);
});

var app = builder.Build(); //when called it builds the app and gets middleware


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // if running in developermode, developerexcettions will be shown. IE error msg to show not logged in 
}

app.UseStaticFiles(); //incoming files for static files. Static middleware
app.MapDefaultControllerRoute();
   // name: "default",
   // Pattern: "{controller=Home}/action=Index}/{id?}"); //defaults MVC to route to pages/uses. Middleware enble MCV to handle incoming requests

DbInitializer.Seed(app); //application builder called to seed data into db (var app = builder.Build();)
app.Run(); //runs application
