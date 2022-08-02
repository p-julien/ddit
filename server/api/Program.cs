using api.Services;
using api.Services.Implementation;
using api.Services.Mock;

var builder = WebApplication.CreateBuilder(args);

// Define mock as project configuration
const bool isMock = false;

// Add services to the container.
_ = isMock ? RegisterMockServices(builder) : RegisterServices(builder);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

bool RegisterServices(WebApplicationBuilder builder)
{
    builder.Services.AddSingleton<IRedditService, RedditService>();
    return true;
}

bool RegisterMockServices(WebApplicationBuilder builder)
{
    builder.Services.AddSingleton<IRedditService, RedditServiceMock>();
    return true;
}