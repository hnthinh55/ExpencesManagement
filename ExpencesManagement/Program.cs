using Expense.API.Queries.CategoryQueries;
using Expenses.Data.Access.DataAccess;
using Expenses.Data.Access.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Add DbContext services
builder.Services.AddDbContext<MyDbContext>(op =>
    op.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnect")));

builder.Services.AddScoped<ICategoryQuery,CategoryQuery>();
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
