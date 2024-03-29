using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton-Scoped-Transient -> Lifetime(ya�am s�resi)
// Singleton => �retilen ba��ml�l�k uygulama a��k oldu�u s�rece tek bir kere newlenir. 
// Her enjeksiyonda o instance kullan�l�r.

// Scoped => (API iste�i) �stek ba��na 1 instance olu�turur.

// Transient => Her ad�mda (her talepte) yeni 1 instance.
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<IProductRepository, EfProductRepository>();
builder.Services.AddDbContext<BaseDbContext>();

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
