using ForFormation;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("DefaultContext");
builder.Services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "detailformations",
    pattern: "les-formations/{id}",
    defaults: new
    {
        controller = "Formation",
        action = "DetailFormation"
    });

app.MapControllerRoute(
    name: "lesformations",
    pattern: "les-formations",
    defaults: new { controller = "Formation", action = "Index"
    });
    

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
