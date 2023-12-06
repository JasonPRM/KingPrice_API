global using KingPrice_API.Models;
using KingPrice_API.Data;
using KingPrice_API.Services.GroupPermissionsService;
using KingPrice_API.Services.GroupsService;
using KingPrice_API.Services.PermsService;
using KingPrice_API.Services.UserDetailsService;
using KingPrice_API.Services.UserGroupsService;
using KingPrice_API.Services.UserService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IGroupsService, GroupsService>();
builder.Services.AddScoped<IPermsService, PermsService>();
builder.Services.AddScoped<IUserGroupsService, UserGroupsService>();
builder.Services.AddScoped<IGroupPermissionsService, GroupPermissionsService>();
builder.Services.AddScoped<IUserDetailsService, UserDetailsService>();
builder.Services.AddDbContext<KingPriceDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("KingPriceConnection")));

//builder.Services.AddOutputCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseOutputCache();

app.UseAuthorization();

app.MapControllers();

app.Run();
