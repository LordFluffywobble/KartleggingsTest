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

builder.Services.AddSingleton<IPlayerContext, PlayerContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");
 
 app.MapGet     ("/helloworld",                 (                               ) => "Hello World");
 app.MapGet     ("/players",                    (        IPlayerContext context ) => Results.Ok(context.GetAllPlayers));
 app.MapGet     ("/players/leveledup",          (        IPlayerContext context ) => context.GetLevelUp());
 app.MapPatch   ("/players/leveledup/{id}",     (int id, IPlayerContext context ) => context.GetLevelUp());
 app.MapDelete  ("/players/{id}",               (int id, IPlayerContext context ) => context.DeletePlayer(id) ? Results.Ok(): Results.NotFound());
 app.MapPost    ("/players",                    (string name, int level, int xp, IPlayerContext context) => context.AddPlayer(name, level, xp));
 


 
 app.Run();