using RenewableEnergyHomes.Api;
using RenewableEnergyHomes.Api.Middleware;
using RenewableEnergyHomes.Infrastructure.DbContexts;
using Serilog;

const string LOCALHOST_CORS_POLICY = "_localhostCorsPolicy";

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .WriteTo.Console()
  .WriteTo.Seq("http://localhost:5341")
  .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen();
builder.Services.AddServices(builder.Configuration);
builder.Services.AddDbContext<PropertyDataContext>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(LOCALHOST_CORS_POLICY,
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(LOCALHOST_CORS_POLICY);
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseUnhandledExceptionMiddleware();
app.Run();
