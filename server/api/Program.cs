using fr.pierrejulien.ddit.api.Services;
using fr.pierrejulien.ddit.api.Services.Implementation;
using fr.pierrejulien.ddit.api.Services.Mock;

var builder = WebApplication.CreateBuilder(args);

// Define mock as project configuration
const bool isMock = false;

// Add services to the container.
_ = isMock ? RegisterMockServices(builder) : RegisterServices(builder);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("DditPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

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

app.UseCors("DditPolicy");

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