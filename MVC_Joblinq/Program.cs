using Microsoft.EntityFrameworkCore;
using MVC_Joblinq.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DB Bağlantısı için - appSettings.json dosyası altındaki Connection tanımı için
builder.Services.AddDbContext<DBJoblinqContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

var app = builder.Build(); // Uygulamanın yaratıldığı kısım

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
