using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using FootballApp2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DbfootballContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
/*builder.Services.AddStackExchangeRedisCache(options =>
{
options.Configuration = builder.Configuration["AZURE_REDIS_CONNECTIONSTRING"];
options.InstanceName = "SampleInstance";
});*/
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Identity_conn"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.BuildServiceProvider().GetService<DbfootballContext>().Database.Migrate();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//app.MapControllers();
//app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.MapControllerRoute(
   name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
