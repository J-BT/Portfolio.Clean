using Portfolio.Clean.Api.Middleware;
using Portfolio.Clean.Application;
using Portfolio.Clean.Infrastructure;
using Portfolio.Clean.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddInfrastuctureServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddControllers();

// Avoids CORS error
// Nb : Replace options.AddPolicy("all", builder => builder.AllowAnyOrigin() by
// options.AddPolicy(name: MyAllowSpecificOrigins, policy  => { policy.WithOrigins("http://example.com",...); });
// to restrict Api access to a limited client numbers
builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Calls the CORS policy defined above
app.UseCors("all");

app.UseAuthorization();

app.MapControllers();

app.Run();
