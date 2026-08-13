using System.Net;
using System.Runtime.InteropServices;
using Kartleggingstest;
using Kartleggingstest.Classes;
using Microsoft.AspNetCore.Components.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
// builder.Services.AddSingleton<ITaskContext, TaskContext>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();