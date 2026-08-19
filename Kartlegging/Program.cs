using System.Net;
using System.Runtime.InteropServices;
using Kartlegging.Interfaces;
using Kartlegging.Models;
using Kartleggingstest;
using Kartleggingstest.Classes;
using Microsoft.AspNetCore.Components.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITaskContext, TaskContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");
 
 app.MapGet ("/helloworld", () => "Hello World");
 
 app.Run();