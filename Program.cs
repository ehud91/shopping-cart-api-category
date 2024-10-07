using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using ShoppingCartApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the MongoDbSettings from appsettings.json
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));

// Register the MongoDbContext as a singleton
builder.Services.AddSingleton<MongoDbContext>();


// Register your services here
builder.Services.AddScoped<ICategoryService, CategoryService>();

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
