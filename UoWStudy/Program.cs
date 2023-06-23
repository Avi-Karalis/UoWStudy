using UoWStudy.Infrastructure.ServiceExtension;
using UoWStudy.Services;
using UoWStudy.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// we areadding the Dependency injection to the builder and the services too
builder.Services.DIServices(builder.Configuration);
builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
