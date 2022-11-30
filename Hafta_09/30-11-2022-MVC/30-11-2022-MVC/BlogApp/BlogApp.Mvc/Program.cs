using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using BlogApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //BlogApp.Mvc içýn bunu kullanacaksýn

#region ServislerBuradaYazýlýrsa
/*
 builder.Services.AddDbContext<BlogAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
 */
#endregion

#region ServiceExtensionIleCagrýlýrsa
builder.Services.LoadMyServices();
#endregion


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}

app.UseHttpsRedirection();
app.UseStaticFiles();//wwwroot kullanýmý ýcýn

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern: "/Admin/{controller=Home}/{action=Index}/{id?}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
