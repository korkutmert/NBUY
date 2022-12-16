using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(optipns=>optipns.UseSqlite("Data Source=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x=> new
SmtpEmailSender (
    "smtp.office365.com",587,true,"wissen_core@hotmail.com","wissen123."
    ));


builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit=true;//�ifrede i�inde mutlaka rakam bulunsun dedik.
    options.Password.RequireLowercase=true;//�ifrede i�inde mutlaka k���k harf bulunsun dedik.
    options.Password.RequireUppercase=true;//�ifrede i�inde mutlaka b�y�k harf bulunsun dedik.
    options.Password.RequiredLength=6;//�ifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric=true;//�ifre i�inde en az bir alfanumerik karakter (.,*/) gibi bulunmas� zorunlu olsun.
    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts=5;// BA�ar�s�z giri� deneme say�s� max 5 olsun dedik . % kez ahatal� giri� olursa hesap kilitlenir
    options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromSeconds(30); // Kilitlenmi� hesab�n tkerar giri� denemesi yapas� i�in 5 dk beklemesi gerek dedik.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kay�t olunur. Yani �nceden kay�t olunmu� e mail ile kay�t olunamaz.
    #endregion
    #endregion
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; // Kullan�c�dan e mail onay� istenir.
    options.SignIn.RequireConfirmedPhoneNumber = false;// Tel no ile onaylama
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; // E�er a��labilmesi i�in login olman�n zorunlu oldu�u bir istekte bulunulursa,kullan�c�n�n y�nlendirece�i sayfa buras� olacakt�r.(account controller daki login action metotu)
    options.LogoutPath = "/account/logout";// Kullan�c� ��k�� yapt���nda y�nlendirecek sayfa
    options.AccessDeniedPath = "/account/accessdenied";//Yetkisiz giri� s�ras�nda y�nlendirilecek sayfa.
    options.SlidingExpiration = true;//Varsay�lan cookie ya�am s�resinin(20dk) yada ayarlanan ya�am s�resinin her yeni istek s�ras�nda s�f�rlanacak yeniden ba�lam�sn� sa�lar
    options.ExpireTimeSpan=TimeSpan.FromMinutes(5);// Ya�am s�resini ayarlama 
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,// Http format�nda �al��acak
        Name=".ShoppingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict
    };

});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
