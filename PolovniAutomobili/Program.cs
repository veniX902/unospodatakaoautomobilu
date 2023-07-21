using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using PolovniAutomobili;
using PolovniAutomobili.Models;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });
builder.Services.AddDbContext<CarContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("PrimaryConnectionString")));
builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (type, factory) =>
    factory.Create(typeof(SharedResource));
});
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en");
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.DefaultThreadCurrentCulture;
CultureInfo.CurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
CultureInfo.CurrentUICulture = CultureInfo.DefaultThreadCurrentCulture;
var app = builder.Build();
var supportedCultures = new[] { "en", "de-DE", "sr" };
var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0]).AddSupportedCultures
    (supportedCultures).AddSupportedUICultures(supportedCultures);


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
