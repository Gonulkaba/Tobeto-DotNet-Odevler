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

// Singleton-Scoped-Transient -> Lifetime(yaþam süresi)
// Singleton => Üretilen baðýmlýlýk uygulama açýk olduðu sürece tek bir kere newlenir. 
// Her enjeksiyonda o instance kullanýlýr.

// Scoped => (API isteði) Ýstek baþýna 1 instance oluþturur.

// Transient => Her adýmda (her talepte) yeni 1 instance.


builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();

//Middleware

//Jwt
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // JWT Konfigürasyonlarý..
        // TODO: Gerekli alanlarý appsettings.json'dan okuyarak burada token optionslarý belirle.
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
