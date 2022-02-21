using Microsoft.EntityFrameworkCore;
using MagnifinanceUniversity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configValue = builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(configValue));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

var host = builder.Host;



var services = builder.Services.BuildServiceProvider();

try
{
    var context = services.GetRequiredService<SchoolContext>();
    DbInitializer.Initialize(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred creating the DB.");
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
