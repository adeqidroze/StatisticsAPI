using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Statistics.Core.Entities;
using Statistics.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("StatisticsDbConnection")));

ConfigureIdentity(builder.Services);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfigureIdentity(IServiceCollection services)
{
    var identityBuilder = services.AddIdentity<UsersEntity, IdentityRole>(options =>
    {
        options.SignIn.RequireConfirmedAccount = true;
    }).AddUserManager<UserManager<UsersEntity>>();
    identityBuilder.AddRoles<IdentityRole>().AddDefaultTokenProviders();
    identityBuilder.AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
}