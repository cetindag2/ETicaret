<<<<<<< HEAD
using ETicaretAPI.API.Extensions;
=======
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
using ETicaretAPI.Application;
using ETicaretAPI.Application.Validators.Products;
using ETicaretAPI.Infrastructure;
using ETicaretAPI.Infrastructure.Filters;
using ETicaretAPI.Infrastructure.Services.Storage.Local;
using ETicaretAPI.Persistence;
<<<<<<< HEAD
using ETicaretAPI.SignalR;
using ETicaretAPI.SignalR.Hubs;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Context;
using Serilog.Core;
=======
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();

builder.Services.AddApplicationServices();  

builder.Services.AddStorage<LocalStorage>();
<<<<<<< HEAD
builder.Services.AddSignalRServices();

builder.Services.AddCors(option => option.AddDefaultPolicy(policy =>
policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
)) ;


Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("MSSQL"), "logs",
        autoCreateSqlTable: true)
        //.WriteTo.Seq(builder.Configuration["Seq:ServerURL"])
    //.Enrich.FromLogContext()
    //.MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});
=======
//builder.Services.AddStorage<AzureStorage>();
//builder.Services.AddStorage();

builder.Services.AddCors(option => option.AddDefaultPolicy(policy =>
policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod()
)) ;
// Add services to the container.
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c

builder.Services.AddControllers(options=> options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>
    ())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true) ;
<<<<<<< HEAD

=======
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer("Admin", options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = false, //Tokeni dogrulayan yer -> www.myclient.com
            ValidateIssuer = false, //Tokenin dogrulandigi yer. -> www.myapi.com
            ValidateLifetime = false, //token  suresini kontrol edecek olan parametre
            ValidateIssuerSigningKey = true, //Guvenlik anahtari

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
<<<<<<< HEAD
            LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false
=======
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c

        };
    });


<<<<<<< HEAD
=======



>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

<<<<<<< HEAD
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
app.UseStaticFiles();

//app.UseSerilogRequestLogging();
app.UseHttpLogging();

=======
app.UseStaticFiles();
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
<<<<<<< HEAD
app.MapHubs();
=======
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c

app.Run();
