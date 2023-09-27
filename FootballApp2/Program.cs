using Microsoft.EntityFrameworkCore;
using FootballApp2.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using FootballApp2.Data;
using FootballApp2.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using FootballApp2.ElasticSearch;
using Syncfusion.JavaScript.DataVisualization.Models;
using Mapbox.AspNetCore.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Configuration;
using Microsoft.FeatureManagement.FeatureFilters;
using FootballApp2.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddSingleton<ITargetingContextAccessor,
            HttpContextTargetingContextAccessor>();
builder.Services.AddFeatureManagement(builder.Configuration.GetSection("Features")).AddFeatureFilter<TargetingFilter>();
//builder.Services.AddFeatureFilter<TargetingFilter>();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DbfootballContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
/*builder.Services.AddStackExchangeRedisCache(options =>
{
options.Configuration = builder.Configuration["AZURE_REDIS_CONNECTIONSTRING"];
options.InstanceName = "SampleInstance";
});*/
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityCSAzure")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddTransient<IEmailSender, EmailService>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/Home/Privacy");
});

builder.Services.AddMapBoxServices(options => options.UseApiKey(builder.Configuration["MapboxApiKey"]));
builder.Services.AddAuthentication().AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
});
//builder.Services.BuildServiceProvider().GetService<DbfootballContext>().Database.Migrate();
builder.Services.AddElasticsearch(builder.Configuration);
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
app.UseAuthentication();
app.UseAuthorization();
//app.MapControllers();
//app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.MapControllerRoute(
   name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
public partial class Program { }