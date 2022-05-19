using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Statistics.Core.Entities;
using Statistics.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("StatisticsDbConnection") ?? throw new InvalidOperationException("Connection string 'DataContextConnection' not found.");

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));;


// Add services to the container.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var identityBuilder=builder.Services.AddIdentity<UsersEntity, IdentityRole>(options => 
{
    options.SignIn.RequireConfirmedAccount = true;
}).AddUserManager<UserManager<UsersEntity>>();
identityBuilder.AddRoles<IdentityRole>().AddDefaultTokenProviders();
identityBuilder.AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
identityBuilder.AddDefaultUI();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
