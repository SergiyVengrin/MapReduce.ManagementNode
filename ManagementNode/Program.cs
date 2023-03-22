using BLL.POCOs;
using BLL.Services.Implementation;
using BLL.Services.Interfaces;
using DAL.Data;
using DAL.Entitites;
using DAL.Repositories.Implementation;
using DAL.Repositories.Interfaces;
using ManagementNode;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<IHttpService, HttpService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddTransient<IMetadataService, MetadataService>();
builder.Services.AddTransient<IMetadataRepository, MetadataRepository>();
builder.Services.AddTransient<IManagementService, ManagementService>();
builder.Services.AddTransient<IHttpService, HttpService>();

builder.Services.Configure<NodeConfig>(builder.Configuration.GetSection("NodeConfig"));

builder.Services.AddControllers();

builder.Services.AddDbContext<MapReduceDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MapReduceDBConnectionString")));



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();
app.Run();