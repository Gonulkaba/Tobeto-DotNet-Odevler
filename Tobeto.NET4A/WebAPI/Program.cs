using Business.Abstracts;
using Business.Concretes;
using Core.CrossCuttingConcerns.Exceptions;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton-Scoped-Transient -> Lifetime(yaþam süresi)
// Singleton => Üretilen baðýmlýlýk uygulama açýk olduðu sürece tek bir kere newlenir. 
// Her enjeksiyonda o instance kullanýlýr.

// Scoped => (API isteði) Ýstek baþýna 1 instance oluþturur.

// Transient => Her adýmda (her talepte) yeni 1 instance.
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductRepository, EfProductRepository>();
builder.Services.AddDbContext<BaseDbContext>();

//Middleware

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

app.ConfigureExceptionMiddlewareExtensions();

app.Run();
