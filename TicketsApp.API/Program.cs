using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TicketsApp.API.Middlewares;
using TicketsApp.Core.Interfaces;
using TicketsApp.Core.Services;
using TicketsApp.Core.Services.Interfaces;
using TicketsApp.DataAccess.Data;
using TicketsApp.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);
var allowSpecificOriginsCors = "AllowSpecificOrigins";

builder.Services.AddCors(options => {
    options.AddPolicy(name: allowSpecificOriginsCors, builder => 
    {
        builder.WithOrigins("http://localhost:3000");
    });
});
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(EFCoreRepository<>));
builder.Services.AddScoped<ITicketService, TicketService>();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ForbiddenBrowsersMiddleware>();

app.UseRouting();
app.UseCors(allowSpecificOriginsCors);
app.MapControllers();

app.Run();
