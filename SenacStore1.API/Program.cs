using Microsoft.EntityFrameworkCore;
using SenacStore1.API.Data;
using SenacStore1.API.Interface;
using SenacStore1.API.Repository;

var builder = WebApplication.CreateBuilder(args);


//config banco de dados
builder.Services.AddDbContext<SenacStore1DbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.
//faltou 
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
