using Business.Abstracts;
using Business.Concretes;
using Core.CrossCuttingConcerns.Exceptions;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using System.Reflection;
using Business;
using DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;

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


builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();

//Middleware

//Jwt
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // JWT Konfig�rasyonlar�..
        // TODO: Gerekli alanlar� appsettings.json'dan okuyarak burada token optionslar� belirle.
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            // IssuerSigningKey = ""
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionMiddlewareExtensions();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
