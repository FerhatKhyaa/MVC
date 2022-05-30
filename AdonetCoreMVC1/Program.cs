using AdonetCoreMVC1.Models;
using AdonetCoreMVC1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Dependency Injection �rnekleri (Burada yapt���m�z i�lem i�erisine bir �ey yaz�lmasa dahil aksi bir durum ya�anmad��� s�rece default bir de�er olarak bunu almas� gerekti�ini s�yl�yor.)

builder.Services.AddScoped<IHesapMakinesi, HesapMakinesiKdv18>();

#endregion

#region Veritaban� Connection Kodumuz ve AddDbContext Veritaban�nu tan�mlama

string connection = @"Server=(localdb)\MSSQLLocalDB;Database=MusteriVt;Trusted_Connection=true";

builder.Services.AddDbContext<MusteriVtContext>(options => options.UseSqlServer(connection));
#endregion

#region Razor Root Dizinimizi Tan�ml�yoruz. (Sayfalar�m�zda data verilerini kullanmayaca��m�z sadece listeleme i�lemi yapaca��m�z verileri tutmak ya da basit d�zey bir css ve Js ile yaz�lm�� olan sayfalar� tutmak i�in kullan�yoruz.)
builder.Services.AddRazorPages().AddRazorPagesOptions(option => { option.RootDirectory = "/Pages"; });
builder.Services.AddControllersWithViews();

#endregion

#region Session Kullan�m� 

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

#region Servis olarak build etmeden �nce tan�mlad���m�z razor sayfalar�m�z� aktif ediyoruz.
app.MapRazorPages();
#endregion

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
